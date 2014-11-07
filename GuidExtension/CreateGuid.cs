using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuidGenerator
{
	public partial class CreateGuidForm : Form
	{
		public CreateGuidForm()
		{
			InitializeComponent();
		}

		private void GenerateButton_Click(object sender, EventArgs e)
		{
			Generate();
		}

		private void CreateGuidForm_Load(object sender, EventArgs e)
		{
			GuidGenerator.Properties.Settings.Default.Reload();
			AutoClipCheckbox.Checked = GuidGenerator.Properties.Settings.Default.CopyToClipboard;
			Generate();
		}

		private void Generate()
		{
			Guid g = Guid.NewGuid();
			GuidTextbox.Text = g.ToString();

			if (AutoClipCheckbox.Checked)
			{
				Clipboard.SetText(g.ToString());
			}
		}

		private void CreateGuidForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			GuidGenerator.Properties.Settings.Default.CopyToClipboard = AutoClipCheckbox.Checked;
			GuidGenerator.Properties.Settings.Default.Save();
		}

		private void CopyButtton_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(GuidTextbox.Text))
			{
				Clipboard.SetText(GuidTextbox.Text);
			}
		}

		private void CreateGuidForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
				Close();
		}
	}
}
