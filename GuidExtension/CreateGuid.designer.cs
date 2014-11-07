namespace GuidGenerator
{
	partial class CreateGuidForm
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
			this.GenerateButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.GuidTextbox = new System.Windows.Forms.TextBox();
			this.AutoClipCheckbox = new System.Windows.Forms.CheckBox();
			this.CopyButtton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// GenerateButton
			// 
			this.GenerateButton.Location = new System.Drawing.Point(350, 32);
			this.GenerateButton.Name = "GenerateButton";
			this.GenerateButton.Size = new System.Drawing.Size(75, 23);
			this.GenerateButton.TabIndex = 0;
			this.GenerateButton.Text = "&Generate";
			this.GenerateButton.UseVisualStyleBackColor = true;
			this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Guid:";
			// 
			// GuidTextbox
			// 
			this.GuidTextbox.Location = new System.Drawing.Point(50, 6);
			this.GuidTextbox.Name = "GuidTextbox";
			this.GuidTextbox.ReadOnly = true;
			this.GuidTextbox.Size = new System.Drawing.Size(375, 20);
			this.GuidTextbox.TabIndex = 2;
			// 
			// AutoClipCheckbox
			// 
			this.AutoClipCheckbox.AutoSize = true;
			this.AutoClipCheckbox.Location = new System.Drawing.Point(50, 36);
			this.AutoClipCheckbox.Name = "AutoClipCheckbox";
			this.AutoClipCheckbox.Size = new System.Drawing.Size(132, 17);
			this.AutoClipCheckbox.TabIndex = 3;
			this.AutoClipCheckbox.Text = "Auto-copy to clipboard";
			this.AutoClipCheckbox.UseVisualStyleBackColor = true;
			// 
			// CopyButtton
			// 
			this.CopyButtton.Location = new System.Drawing.Point(269, 32);
			this.CopyButtton.Name = "CopyButtton";
			this.CopyButtton.Size = new System.Drawing.Size(75, 23);
			this.CopyButtton.TabIndex = 4;
			this.CopyButtton.Text = "&Copy";
			this.CopyButtton.UseVisualStyleBackColor = true;
			this.CopyButtton.Click += new System.EventHandler(this.CopyButtton_Click);
			// 
			// CreateGuidForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(437, 72);
			this.Controls.Add(this.CopyButtton);
			this.Controls.Add(this.AutoClipCheckbox);
			this.Controls.Add(this.GuidTextbox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.GenerateButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CreateGuidForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Create Guid";
			this.Load += new System.EventHandler(this.CreateGuidForm_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CreateGuidForm_KeyDown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button GenerateButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox GuidTextbox;
		private System.Windows.Forms.CheckBox AutoClipCheckbox;
		private System.Windows.Forms.Button CopyButtton;
	}
}