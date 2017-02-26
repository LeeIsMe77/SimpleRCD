namespace RCD.Client.Management {
	partial class About {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.createdByLabel = new System.Windows.Forms.Label();
			this.createdBy = new System.Windows.Forms.Label();
			this.contactEmailLabel = new System.Windows.Forms.Label();
			this.contactEmail = new System.Windows.Forms.LinkLabel();
			this.language = new System.Windows.Forms.Label();
			this.languageLabel = new System.Windows.Forms.Label();
			this.thanks = new System.Windows.Forms.Label();
			this.thanksLabel = new System.Windows.Forms.Label();
			this.close = new System.Windows.Forms.Button();
			this.buttonPanel = new System.Windows.Forms.Panel();
			this.buttonPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// createdByLabel
			// 
			this.createdByLabel.Location = new System.Drawing.Point(48, 22);
			this.createdByLabel.Name = "createdByLabel";
			this.createdByLabel.Size = new System.Drawing.Size(100, 20);
			this.createdByLabel.TabIndex = 0;
			this.createdByLabel.Text = "Created By:";
			this.createdByLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// createdBy
			// 
			this.createdBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.createdBy.Location = new System.Drawing.Point(154, 22);
			this.createdBy.Name = "createdBy";
			this.createdBy.Size = new System.Drawing.Size(250, 20);
			this.createdBy.TabIndex = 1;
			this.createdBy.Text = "Lee Gurley";
			this.createdBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// contactEmailLabel
			// 
			this.contactEmailLabel.Location = new System.Drawing.Point(48, 42);
			this.contactEmailLabel.Name = "contactEmailLabel";
			this.contactEmailLabel.Size = new System.Drawing.Size(100, 20);
			this.contactEmailLabel.TabIndex = 2;
			this.contactEmailLabel.Text = "Contact Email:";
			this.contactEmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// contactEmail
			// 
			this.contactEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.contactEmail.Location = new System.Drawing.Point(154, 41);
			this.contactEmail.Name = "contactEmail";
			this.contactEmail.Size = new System.Drawing.Size(250, 23);
			this.contactEmail.TabIndex = 4;
			this.contactEmail.TabStop = true;
			this.contactEmail.Text = "LeeIsMe@gmail.com";
			this.contactEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// language
			// 
			this.language.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.language.Location = new System.Drawing.Point(154, 62);
			this.language.Name = "language";
			this.language.Size = new System.Drawing.Size(250, 20);
			this.language.TabIndex = 6;
			this.language.Text = "C#";
			this.language.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// languageLabel
			// 
			this.languageLabel.Location = new System.Drawing.Point(48, 62);
			this.languageLabel.Name = "languageLabel";
			this.languageLabel.Size = new System.Drawing.Size(100, 20);
			this.languageLabel.TabIndex = 5;
			this.languageLabel.Text = "Language:";
			this.languageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// thanks
			// 
			this.thanks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.thanks.Location = new System.Drawing.Point(154, 82);
			this.thanks.Name = "thanks";
			this.thanks.Size = new System.Drawing.Size(250, 20);
			this.thanks.TabIndex = 8;
			this.thanks.Text = "Everyone affiliated with this delightful MUD!";
			this.thanks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// thanksLabel
			// 
			this.thanksLabel.Location = new System.Drawing.Point(48, 82);
			this.thanksLabel.Name = "thanksLabel";
			this.thanksLabel.Size = new System.Drawing.Size(100, 20);
			this.thanksLabel.TabIndex = 7;
			this.thanksLabel.Text = "Special Thanks:";
			this.thanksLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// close
			// 
			this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.close.Location = new System.Drawing.Point(338, 4);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(75, 23);
			this.close.TabIndex = 9;
			this.close.Text = "Close";
			this.close.UseVisualStyleBackColor = true;
			this.close.Click += new System.EventHandler(this.close_Click);
			// 
			// buttonPanel
			// 
			this.buttonPanel.Controls.Add(this.close);
			this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.buttonPanel.Location = new System.Drawing.Point(0, 144);
			this.buttonPanel.Name = "buttonPanel";
			this.buttonPanel.Size = new System.Drawing.Size(416, 30);
			this.buttonPanel.TabIndex = 10;
			// 
			// HelpForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(416, 174);
			this.Controls.Add(this.buttonPanel);
			this.Controls.Add(this.thanks);
			this.Controls.Add(this.thanksLabel);
			this.Controls.Add(this.language);
			this.Controls.Add(this.languageLabel);
			this.Controls.Add(this.contactEmail);
			this.Controls.Add(this.contactEmailLabel);
			this.Controls.Add(this.createdBy);
			this.Controls.Add(this.createdByLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "HelpForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About...";
			this.buttonPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label createdByLabel;
		private System.Windows.Forms.Label createdBy;
		private System.Windows.Forms.Label contactEmailLabel;
		private System.Windows.Forms.LinkLabel contactEmail;
		private System.Windows.Forms.Label language;
		private System.Windows.Forms.Label languageLabel;
		private System.Windows.Forms.Label thanks;
		private System.Windows.Forms.Label thanksLabel;
		private System.Windows.Forms.Button close;
		private System.Windows.Forms.Panel buttonPanel;
	}
}