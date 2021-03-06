﻿using Kinovea.Pipeline;
using Kinovea.Pipeline.Consumers;
using System.IO;
using System;
using Kinovea.Video;
using Kinovea.Video.FFMpeg;
using System.Drawing;
using Kinovea.Services;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Kinovea.ScreenManager
{
    /// <summary>
    /// ConsumerDelayer. 
    /// Push frames coming from the camera into the delay buffer. 
    /// Pulls from the delay buffer and saves to file.
    /// </summary>
    public class ConsumerDelayer : AbstractConsumer
    {
        public string Filename
        {
            get { return filename; }
        }

        public bool Recording
        {
            get { return recording; }
        }

        public long Ellapsed { get; private set; }

        private bool allocated;
        private Delayer delayer;
        private int age;
        private ImageDescriptor delayerImageDescriptor;
        private Frame delayedFrame;
        private MJPEGWriter writer;
        private bool recording;
        private string filename;
        private bool stopRecordAsked;
        private string shortId;
        private Stopwatch stopwatch = new Stopwatch();
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ConsumerDelayer(string shortId)
        {
            this.shortId = shortId;
            stopwatch.Start();
        }

        /// <summary>
        /// Set the image descriptor for the incoming frames.
        /// </summary>
        public void SetImageDescriptor(ImageDescriptor imageDescriptor)
        {
            // Allocate a long-lived frame we will use to collect delayed frames and send them to the writer.
            if (delayedFrame != null)
            {
                delayedFrame = null;
            }

            GC.Collect();

            allocated = false;

            try
            {
                // Prepare the long-lived delayed frame.
                delayerImageDescriptor = imageDescriptor;
                delayedFrame = new Frame(delayerImageDescriptor.BufferSize);
                
                allocated = true;
            }
            catch (Exception e)
            {
                log.Error("The buffer could not be allocated.");
                log.Error(e);
            }
        }


        public void PrepareDelay(Delayer delayer)
        {
            this.delayer = delayer;
        }

        public SaveResult StartRecord(string filename, double interval, int age)
        {
            //-----------------------
            // Runs on the UI thread.
            //-----------------------

            if (delayerImageDescriptor == null)
                throw new NotSupportedException("ImageDescriptor must be set before prepare.");

            this.age = age;
            this.filename = filename;

            if (writer != null)
                writer.Dispose();

            writer = new MJPEGWriter();

            VideoInfo info = new VideoInfo();
            info.OriginalSize = new Size(delayerImageDescriptor.Width, delayerImageDescriptor.Height);

            bool uncompressed = PreferencesManager.CapturePreferences.SaveUncompressedVideo && delayerImageDescriptor.Format != Video.ImageFormat.JPEG;
            string formatString = FilenameHelper.GetFormatStringCapture(uncompressed);

            // If the capture happens too fast or too slow for a regular player, set the video metadata to a more sensible framerate.
            // This avoids erratic playback because the player can't cope with the framerate, drawback: prevents review in real time.
            double hrft = PreferencesManager.CapturePreferences.HighspeedRecordingFramerateThreshold;
            double srft = PreferencesManager.CapturePreferences.SlowspeedRecordingFramerateThreshold;
            double fps = 1000.0 / interval;
            double fileInterval = interval;
            if (fps >= hrft)
            {
                double hrfo = PreferencesManager.CapturePreferences.HighspeedRecordingFramerateOutput;
                fileInterval = 1000.0 / hrfo;
                log.DebugFormat("High speed recording detected, {0:0.###} fps. Forcing output framerate to {1:0.###} fps.", fps, hrfo);
            }
            else if (fps <= srft)
            {
                double srfo = PreferencesManager.CapturePreferences.SlowspeedRecordingFramerateOutput;
                fileInterval = 1000.0 / srfo;
                log.DebugFormat("Slow speed recording detected, {0:0.###} fps. Forcing output framerate to {1:0.###} fps.", fps, srfo);
            }

            log.DebugFormat("Frame budget for writer [{0}]: {1:0.000} ms.", shortId, interval);

            SaveResult result = writer.OpenSavingContext(filename, info, formatString, delayerImageDescriptor.Format, uncompressed, interval, fileInterval);

            recording = true;

            return result;
        }

        public void StopRecord()
        {
            //-----------------------
            // Runs on the UI thread.
            //-----------------------
            stopRecordAsked = true;
        }

        protected override void AfterDeactivate()
        {
            if (recording)
                DoStopRecord();

            base.AfterDeactivate();
        }

        protected override void ProcessEntry(long position, Frame entry)
        {
            if (!allocated)
                return;

            long then = stopwatch.ElapsedMilliseconds;

            // We don't move back this call to the UI thread.
            // During recording we extract frames from the delayer on that very same thread, 
            // and for the display it's not critical that the images be broken. (less critical than switching context each frame).
            // As this mode is tailored for delay scenario, in all likelihood the display is not going to be reading the frame we are writing to.
            bool pushed = delayer.Push(entry);
            if (!pushed)
            {
                // Very critical error. Most likely cross thread access to the same frame.
                // Let's deactivate to avoid looping on the error.
                log.ErrorFormat("Critical error while trying to push frame to delayer.");
                DoStopRecord();
                Deactivate();
            }

            if (stopRecordAsked)
            {
                DoStopRecord();
            }
            else if (recording)
            {
                // Extract a bitmap from delayer at right delay and convert it into a frame for the writer.
                // Note that we do not go through the delay compositer. We only support "normal" delay here.
                // Compositers (e.g: quadrants with different ages) are only supported in display.
                bool copied = delayer.GetStrong(age, delayedFrame);
                if (copied)
                    writer.SaveFrame(delayerImageDescriptor.Format, delayedFrame.Buffer, delayedFrame.PayloadLength, delayerImageDescriptor.TopDown);
            }

            Ellapsed = stopwatch.ElapsedMilliseconds - then;
        }

        private void DoStopRecord()
        {
            //---------------------------------------
            // Must be called on the consumer thread.
            //---------------------------------------
            stopRecordAsked = false;

            if (!recording)
                return;

            writer.CloseSavingContext(true);
            writer.Dispose();
            writer = null;

            recording = false;
        }
    }
}
