﻿namespace Kinovea.ScreenManager
{
    partial class FormCalibrateDistortion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCalibrate = new System.Windows.Forms.Button();
            this.grpDistortionCoefficients = new System.Windows.Forms.GroupBox();
            this.lblP2 = new System.Windows.Forms.Label();
            this.lblP1 = new System.Windows.Forms.Label();
            this.lblK3 = new System.Windows.Forms.Label();
            this.lblK2 = new System.Windows.Forms.Label();
            this.lblK1 = new System.Windows.Forms.Label();
            this.grpIntrinsics = new System.Windows.Forms.GroupBox();
            this.lblCy = new System.Windows.Forms.Label();
            this.lblCx = new System.Windows.Forms.Label();
            this.lblFy = new System.Windows.Forms.Label();
            this.lblFx = new System.Windows.Forms.Label();
            this.tabPages = new System.Windows.Forms.TabControl();
            this.tabDistortion = new System.Windows.Forms.TabPage();
            this.tabImage = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuImport = new System.Windows.Forms.ToolStripMenuItem();
            this.pbDistortion = new System.Windows.Forms.PictureBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuImportAgisoft = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpDistortionCoefficients.SuspendLayout();
            this.grpIntrinsics.SuspendLayout();
            this.tabPages.SuspendLayout();
            this.tabDistortion.SuspendLayout();
            this.tabImage.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDistortion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(386, 245);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(99, 24);
            this.btnOK.TabIndex = 31;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(491, 245);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 24);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnCalibrate
            // 
            this.btnCalibrate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCalibrate.Location = new System.Drawing.Point(12, 246);
            this.btnCalibrate.Name = "btnCalibrate";
            this.btnCalibrate.Size = new System.Drawing.Size(115, 23);
            this.btnCalibrate.TabIndex = 33;
            this.btnCalibrate.Text = "Calibrate camera";
            this.btnCalibrate.UseVisualStyleBackColor = true;
            this.btnCalibrate.Click += new System.EventHandler(this.btnCalibrate_Click);
            // 
            // grpDistortionCoefficients
            // 
            this.grpDistortionCoefficients.Controls.Add(this.lblP2);
            this.grpDistortionCoefficients.Controls.Add(this.lblP1);
            this.grpDistortionCoefficients.Controls.Add(this.lblK3);
            this.grpDistortionCoefficients.Controls.Add(this.lblK2);
            this.grpDistortionCoefficients.Controls.Add(this.lblK1);
            this.grpDistortionCoefficients.Location = new System.Drawing.Point(12, 35);
            this.grpDistortionCoefficients.Name = "grpDistortionCoefficients";
            this.grpDistortionCoefficients.Size = new System.Drawing.Size(237, 108);
            this.grpDistortionCoefficients.TabIndex = 35;
            this.grpDistortionCoefficients.TabStop = false;
            this.grpDistortionCoefficients.Text = "Distortion coefficients";
            // 
            // lblP2
            // 
            this.lblP2.AutoSize = true;
            this.lblP2.Location = new System.Drawing.Point(131, 51);
            this.lblP2.Name = "lblP2";
            this.lblP2.Size = new System.Drawing.Size(25, 13);
            this.lblP2.TabIndex = 4;
            this.lblP2.Text = "p2 :";
            // 
            // lblP1
            // 
            this.lblP1.AutoSize = true;
            this.lblP1.Location = new System.Drawing.Point(131, 28);
            this.lblP1.Name = "lblP1";
            this.lblP1.Size = new System.Drawing.Size(25, 13);
            this.lblP1.TabIndex = 3;
            this.lblP1.Text = "p1 :";
            // 
            // lblK3
            // 
            this.lblK3.AutoSize = true;
            this.lblK3.Location = new System.Drawing.Point(18, 78);
            this.lblK3.Name = "lblK3";
            this.lblK3.Size = new System.Drawing.Size(25, 13);
            this.lblK3.TabIndex = 2;
            this.lblK3.Text = "k3 :";
            // 
            // lblK2
            // 
            this.lblK2.AutoSize = true;
            this.lblK2.Location = new System.Drawing.Point(18, 51);
            this.lblK2.Name = "lblK2";
            this.lblK2.Size = new System.Drawing.Size(25, 13);
            this.lblK2.TabIndex = 1;
            this.lblK2.Text = "k2 :";
            // 
            // lblK1
            // 
            this.lblK1.AutoSize = true;
            this.lblK1.Location = new System.Drawing.Point(18, 28);
            this.lblK1.Name = "lblK1";
            this.lblK1.Size = new System.Drawing.Size(25, 13);
            this.lblK1.TabIndex = 0;
            this.lblK1.Text = "k1 :";
            // 
            // grpIntrinsics
            // 
            this.grpIntrinsics.Controls.Add(this.lblCy);
            this.grpIntrinsics.Controls.Add(this.lblCx);
            this.grpIntrinsics.Controls.Add(this.lblFy);
            this.grpIntrinsics.Controls.Add(this.lblFx);
            this.grpIntrinsics.Location = new System.Drawing.Point(12, 149);
            this.grpIntrinsics.Name = "grpIntrinsics";
            this.grpIntrinsics.Size = new System.Drawing.Size(237, 86);
            this.grpIntrinsics.TabIndex = 36;
            this.grpIntrinsics.TabStop = false;
            this.grpIntrinsics.Text = "Camera intrinsics";
            // 
            // lblCy
            // 
            this.lblCy.AutoSize = true;
            this.lblCy.Location = new System.Drawing.Point(131, 49);
            this.lblCy.Name = "lblCy";
            this.lblCy.Size = new System.Drawing.Size(24, 13);
            this.lblCy.TabIndex = 8;
            this.lblCy.Text = "cy :";
            // 
            // lblCx
            // 
            this.lblCx.AutoSize = true;
            this.lblCx.Location = new System.Drawing.Point(131, 26);
            this.lblCx.Name = "lblCx";
            this.lblCx.Size = new System.Drawing.Size(24, 13);
            this.lblCx.TabIndex = 7;
            this.lblCx.Text = "cx :";
            // 
            // lblFy
            // 
            this.lblFy.AutoSize = true;
            this.lblFy.Location = new System.Drawing.Point(18, 49);
            this.lblFy.Name = "lblFy";
            this.lblFy.Size = new System.Drawing.Size(21, 13);
            this.lblFy.TabIndex = 6;
            this.lblFy.Text = "fy :";
            // 
            // lblFx
            // 
            this.lblFx.AutoSize = true;
            this.lblFx.Location = new System.Drawing.Point(18, 26);
            this.lblFx.Name = "lblFx";
            this.lblFx.Size = new System.Drawing.Size(21, 13);
            this.lblFx.TabIndex = 5;
            this.lblFx.Text = "fx :";
            // 
            // tabPages
            // 
            this.tabPages.Controls.Add(this.tabDistortion);
            this.tabPages.Controls.Add(this.tabImage);
            this.tabPages.Location = new System.Drawing.Point(265, 32);
            this.tabPages.Name = "tabPages";
            this.tabPages.SelectedIndex = 0;
            this.tabPages.Size = new System.Drawing.Size(325, 203);
            this.tabPages.TabIndex = 37;
            // 
            // tabDistortion
            // 
            this.tabDistortion.Controls.Add(this.pbDistortion);
            this.tabDistortion.Location = new System.Drawing.Point(4, 22);
            this.tabDistortion.Name = "tabDistortion";
            this.tabDistortion.Padding = new System.Windows.Forms.Padding(3);
            this.tabDistortion.Size = new System.Drawing.Size(317, 177);
            this.tabDistortion.TabIndex = 0;
            this.tabDistortion.Text = "Distortion";
            this.tabDistortion.UseVisualStyleBackColor = true;
            // 
            // tabImage
            // 
            this.tabImage.Controls.Add(this.pbImage);
            this.tabImage.Location = new System.Drawing.Point(4, 22);
            this.tabImage.Name = "tabImage";
            this.tabImage.Padding = new System.Windows.Forms.Padding(3);
            this.tabImage.Size = new System.Drawing.Size(317, 205);
            this.tabImage.TabIndex = 1;
            this.tabImage.Text = "Image";
            this.tabImage.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(602, 24);
            this.menuStrip1.TabIndex = 41;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpen,
            this.mnuSave,
            this.mnuImport,
            this.mnuDefault,
            this.mnuQuit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuImport
            // 
            this.mnuImport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuImportAgisoft});
            this.mnuImport.Name = "mnuImport";
            this.mnuImport.Size = new System.Drawing.Size(159, 22);
            this.mnuImport.Text = "Import";
            // 
            // pbDistortion
            // 
            this.pbDistortion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.pbDistortion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbDistortion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbDistortion.Location = new System.Drawing.Point(3, 3);
            this.pbDistortion.Name = "pbDistortion";
            this.pbDistortion.Size = new System.Drawing.Size(311, 171);
            this.pbDistortion.TabIndex = 0;
            this.pbDistortion.TabStop = false;
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImage.Location = new System.Drawing.Point(3, 3);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(311, 199);
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            this.pbImage.Click += new System.EventHandler(this.pbImage_Click);
            // 
            // mnuOpen
            // 
            this.mnuOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mnuOpen.Image = global::Kinovea.ScreenManager.Properties.Resources.folder;
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(159, 22);
            this.mnuOpen.Text = "Open";
            // 
            // mnuSave
            // 
            this.mnuSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mnuSave.Image = global::Kinovea.ScreenManager.Properties.Resources.filesave;
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(159, 22);
            this.mnuSave.Text = "Save";
            // 
            // mnuImportAgisoft
            // 
            this.mnuImportAgisoft.Image = global::Kinovea.ScreenManager.Properties.Resources.ruler_triangle;
            this.mnuImportAgisoft.Name = "mnuImportAgisoft";
            this.mnuImportAgisoft.Size = new System.Drawing.Size(152, 22);
            this.mnuImportAgisoft.Text = "Agisoft Lens";
            // 
            // mnuDefault
            // 
            this.mnuDefault.Image = global::Kinovea.ScreenManager.Properties.Resources.bin_empty;
            this.mnuDefault.Name = "mnuDefault";
            this.mnuDefault.Size = new System.Drawing.Size(159, 22);
            this.mnuDefault.Text = "Restore default";
            // 
            // mnuQuit
            // 
            this.mnuQuit.Image = global::Kinovea.ScreenManager.Properties.Resources.quit;
            this.mnuQuit.Name = "mnuQuit";
            this.mnuQuit.Size = new System.Drawing.Size(159, 22);
            this.mnuQuit.Text = "Quit";
            // 
            // FormCalibrateDistortion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(602, 281);
            this.Controls.Add(this.tabPages);
            this.Controls.Add(this.grpIntrinsics);
            this.Controls.Add(this.grpDistortionCoefficients);
            this.Controls.Add(this.btnCalibrate);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalibrateDistortion";
            this.Text = "FormCalibrateDistortion";
            this.grpDistortionCoefficients.ResumeLayout(false);
            this.grpDistortionCoefficients.PerformLayout();
            this.grpIntrinsics.ResumeLayout(false);
            this.grpIntrinsics.PerformLayout();
            this.tabPages.ResumeLayout(false);
            this.tabDistortion.ResumeLayout(false);
            this.tabImage.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDistortion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCalibrate;
        private System.Windows.Forms.GroupBox grpDistortionCoefficients;
        private System.Windows.Forms.Label lblP2;
        private System.Windows.Forms.Label lblP1;
        private System.Windows.Forms.Label lblK3;
        private System.Windows.Forms.Label lblK2;
        private System.Windows.Forms.Label lblK1;
        private System.Windows.Forms.GroupBox grpIntrinsics;
        private System.Windows.Forms.Label lblCy;
        private System.Windows.Forms.Label lblCx;
        private System.Windows.Forms.Label lblFy;
        private System.Windows.Forms.Label lblFx;
        private System.Windows.Forms.TabControl tabPages;
        private System.Windows.Forms.TabPage tabDistortion;
        private System.Windows.Forms.PictureBox pbDistortion;
        private System.Windows.Forms.TabPage tabImage;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuImport;
        private System.Windows.Forms.ToolStripMenuItem mnuImportAgisoft;
        private System.Windows.Forms.ToolStripMenuItem mnuDefault;
        private System.Windows.Forms.ToolStripMenuItem mnuQuit;
    }
}