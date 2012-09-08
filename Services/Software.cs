﻿#region License
/*
Copyright © Joan Charmant 2012.
joan.charmant@gmail.com 
 
This file is part of Kinovea.

Kinovea is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License version 2 
as published by the Free Software Foundation.

Kinovea is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with Kinovea. If not, see http://www.gnu.org/licenses/.
*/
#endregion
using System;
using System.IO;
using System.Windows.Forms;

namespace Kinovea.Services
{
    public class Software
    {
        public static string ApplicationName { get { return "Kinovea";}}
        public static bool Experimental { get { return true;}}
        
        public static string Version { get; private set; }
        public static string SettingsDirectory { get; private set; }
        public static string ColorProfileDirectory { get; private set; }
        public static string PreferencesFile { get; private set; }
        public static string TempDirectory { get; private set; }
        public static string HelpVideosDirectory { get; private set; }
        public static string ManualsDirectory { get; private set; }
        public static string LocalHelpIndex { get; private set; }
        public static string RemoteHelpIndex { get; private set; }
        
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        
        public static void Initialize(Version version)
        {
            Version = string.Format("{0}.{1}.{2}", version.Major, version.Minor, version.Build);
            SettingsDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + ApplicationName + "\\";
            ColorProfileDirectory = SettingsDirectory + "ColorProfiles\\";
            PreferencesFile = SettingsDirectory + "Preferences.xml";
            TempDirectory = SettingsDirectory + "Temp\\";
            
            string applicationDirectory = Application.StartupPath;
            
            HelpVideosDirectory = applicationDirectory + "HelpVideos\\";
            ManualsDirectory = applicationDirectory + "Manuals\\";
            LocalHelpIndex = applicationDirectory + "HelpIndex.xml";
            
            RemoteHelpIndex = Experimental ? "http://www.kinovea.org/setup/updatebeta.xml" : "http://www.kinovea.org/setup/update.xml";
        }
        
        public static void SanityCheckDirectories()
        {
        	if(!Directory.Exists(SettingsDirectory))
        		Directory.CreateDirectory (SettingsDirectory);
        	
        	if(!Directory.Exists(ColorProfileDirectory))
        	   	Directory.CreateDirectory(ColorProfileDirectory);
        }
        
        public static void LogInfo()
        {
             if(Experimental)
                log.InfoFormat("{0} version {1}.");
            else
                log.InfoFormat("{0} version {1} - Experimental release.");
            
            log.Info(".NET Framework Version : " + Environment.Version.ToString());
            log.Info("OS Version : " + Environment.OSVersion.ToString());
            log.Info("Primary Screen : " + SystemInformation.PrimaryMonitorSize.ToString());
            log.Info("Virtual Screen : " + SystemInformation.VirtualScreen.ToString());
        }
    }
}