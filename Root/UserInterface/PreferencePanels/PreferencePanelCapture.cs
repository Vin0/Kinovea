#region License
/*
Copyright � Joan Charmant 2011.
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
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using Kinovea.Root.Languages;
using Kinovea.Root.Properties;
using Kinovea.ScreenManager;
using Kinovea.Services;

namespace Kinovea.Root
{
	/// <summary>
	/// PreferencePanelCapture.
	/// </summary>
	public partial class PreferencePanelCapture : UserControl, IPreferencePanel
	{
		#region IPreferencePanel properties
		public string Description
		{
			get { return m_Description;}
		}
		public Bitmap Icon
		{
			get { return m_Icon;}
		}
		private string m_Description;
		private Bitmap m_Icon;
		#endregion
		
		#region Members
		private bool m_bUsePattern;
		private string m_Pattern;
		private bool m_bResetCounter;
		private long m_iCounter;
		
		private PreferencesManager m_prefManager;
		private FilenameHelper m_filenameHelper = new FilenameHelper();
		#endregion
		
		#region Construction & Initialization
		public PreferencePanelCapture()
		{
			InitializeComponent();
			this.BackColor = Color.White;
			
			m_prefManager = PreferencesManager.Instance();
			
			m_Description = RootLang.dlgPreferences_btnCapture;
			m_Icon = Resources.pref_capture;
			
			// Use the tag property of labels to store the actual marker.
			lblYear.Tag = "%y";
			lblMonth.Tag = "%mo";
			lblDay.Tag = "%d";
			lblHour.Tag = "%h";
			lblMinute.Tag = "%mi";
			lblSecond.Tag = "%s";
			lblCounter.Tag = "%i";
			
			ImportPreferences();
			InitPage();
		}
		private void ImportPreferences()
        {
			m_bUsePattern = m_prefManager.CaptureUsePattern;
			m_Pattern = m_prefManager.CapturePattern;
			m_iCounter = m_prefManager.CaptureImageCounter; // Use the image counter for sample.
		}
		private void InitPage()
		{
			tabGeneral.Text = RootLang.dlgPreferences_ButtonGeneral;
			tabNaming.Text = RootLang.dlgPreferences_Capture_tabNaming;
			rbFreeText.Text = RootLang.dlgPreferences_Capture_rbFreeText;
			rbPattern.Text = RootLang.dlgPreferences_Capture_rbPattern;
			lblYear.Text = RootLang.dlgPreferences_Capture_lblYear;
			lblMonth.Text = RootLang.dlgPreferences_Capture_lblMonth;
			lblDay.Text = RootLang.dlgPreferences_Capture_lblDay;
			lblHour.Text = RootLang.dlgPreferences_Capture_lblHour;
			lblMinute.Text = RootLang.dlgPreferences_Capture_lblMinute;
			lblSecond.Text = RootLang.dlgPreferences_Capture_lblSecond;
			lblCounter.Text = RootLang.dlgPreferences_Capture_lblCounter;
			btnResetCounter.Text = RootLang.dlgPreferences_Capture_btnResetCounter;
			
			tbPattern.Text = m_Pattern;
			UpdateSample();
			
			rbPattern.Checked = m_bUsePattern;
			rbFreeText.Checked = !m_bUsePattern;
		}
		#endregion
		
		#region Handlers
		private void tbPattern_TextChanged(object sender, EventArgs e)
		{
			if(m_filenameHelper.ValidateFilename(tbPattern.Text, true))
			{
				UpdateSample();
			}
			else
			{
				ScreenManager.ScreenManagerKernel.AlertInvalidFileName();
			}
		}
		private void btnMarker_Click(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			if(btn != null)
			{
				int selStart = tbPattern.SelectionStart;
				tbPattern.Text = tbPattern.Text.Insert(selStart, btn.Text);
				tbPattern.SelectionStart = selStart + btn.Text.Length;
			}
		}
		private void lblMarker_Click(object sender, EventArgs e)
		{
			Label lbl = sender as Label;
			if(lbl != null)
			{
				string macro = lbl.Tag as string;
				if(macro != null)
				{
					int selStart = tbPattern.SelectionStart;
					tbPattern.Text = tbPattern.Text.Insert(selStart, macro);
					tbPattern.SelectionStart = selStart + macro.Length;
				}
			}	
		}
		private void btnResetCounter_Click(object sender, EventArgs e)
		{
			m_bResetCounter = true;
			m_iCounter = 1;
			UpdateSample();
		}
		private void RbFreeTextCheckedChanged(object sender, EventArgs e)
		{
			m_bUsePattern = rbPattern.Checked;
			EnableDisablePattern(m_bUsePattern);
		}
		#endregion
		
		#region Private methods
		private void UpdateSample()
		{
			string sample = m_filenameHelper.ConvertPattern(tbPattern.Text, m_iCounter);
			// TODO: check for invalid chars.
			lblSample.Text = sample;
			m_Pattern = tbPattern.Text;
		}
		private void EnableDisablePattern(bool _bEnable)
		{
			tbPattern.Enabled = _bEnable;
			lblSample.Enabled = _bEnable;
			btnYear.Enabled = _bEnable;
			btnMonth.Enabled = _bEnable;
			btnDay.Enabled = _bEnable;
			btnHour.Enabled = _bEnable;
			btnMinute.Enabled = _bEnable;
			btnSecond.Enabled = _bEnable;
			btnIncrement.Enabled = _bEnable;
			btnResetCounter.Enabled = _bEnable;
			lblYear.Enabled = _bEnable;
			lblMonth.Enabled = _bEnable;
			lblDay.Enabled = _bEnable;
			lblHour.Enabled = _bEnable;
			lblMinute.Enabled = _bEnable;
			lblSecond.Enabled = _bEnable;
			lblCounter.Enabled = _bEnable;
		}
		#endregion
		
		public void CommitChanges()
		{
			m_prefManager.CapturePattern = m_Pattern;
			m_prefManager.CaptureUsePattern = m_bUsePattern;
			if(m_bResetCounter)
			{
				m_prefManager.CaptureImageCounter = 1;
				m_prefManager.CaptureVideoCounter = 1;
			}
		}
	}
}
