namespace RCD.Client.Management {
	partial class RCDForm {
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.headerLabel = new System.Windows.Forms.Label();
			this.add = new System.Windows.Forms.Button();
			this.delete = new System.Windows.Forms.Button();
			this.selectedProfile = new System.Windows.Forms.ComboBox();
			this.selectedClassLabel = new System.Windows.Forms.Label();
			this.buttonPanel = new System.Windows.Forms.Panel();
			this.copy = new System.Windows.Forms.Button();
			this.pointsRemaining = new System.Windows.Forms.Label();
			this.pointsRemainingLabel = new System.Windows.Forms.Label();
			this.clear = new System.Windows.Forms.Button();
			this.close = new System.Windows.Forms.Button();
			this.raceFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.whitieRadio = new System.Windows.Forms.RadioButton();
			this.urukHaiRadio = new System.Windows.Forms.RadioButton();
			this.orcRadio = new System.Windows.Forms.RadioButton();
			this.raceLabel = new System.Windows.Forms.Label();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.resetClassesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modifiedMage = new System.Windows.Forms.TextBox();
			this.modifiedMystic = new System.Windows.Forms.TextBox();
			this.modifiedRanger = new System.Windows.Forms.TextBox();
			this.modifiedWarrior = new System.Windows.Forms.TextBox();
			this.modifiedLevelLabel = new System.Windows.Forms.Label();
			this.mageLevel = new System.Windows.Forms.TextBox();
			this.mageLabel = new System.Windows.Forms.Label();
			this.mysticLevel = new System.Windows.Forms.TextBox();
			this.mysticLabel = new System.Windows.Forms.Label();
			this.warriorLevel = new System.Windows.Forms.TextBox();
			this.rangerLevel = new System.Windows.Forms.TextBox();
			this.rangerLabel = new System.Windows.Forms.Label();
			this.levelLabel = new System.Windows.Forms.Label();
			this.warriorLabel = new System.Windows.Forms.Label();
			this.pointsLabel = new System.Windows.Forms.Label();
			this.rangerPoints = new System.Windows.Forms.TextBox();
			this.magePoints = new System.Windows.Forms.TextBox();
			this.warriorPoints = new System.Windows.Forms.TextBox();
			this.mysticPoints = new System.Windows.Forms.TextBox();
			this.skillsGridView = new System.Windows.Forms.DataGridView();
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.skillNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.skillClassColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.skillLevelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.skillSpecializationTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.skillRaceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.buttonPanel.SuspendLayout();
			this.raceFlowLayoutPanel.SuspendLayout();
			this.menuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.skillsGridView)).BeginInit();
			this.tableLayoutPanel.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// headerLabel
			// 
			this.headerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.headerLabel.Location = new System.Drawing.Point(15, 0);
			this.headerLabel.Name = "headerLabel";
			this.headerLabel.Size = new System.Drawing.Size(594, 50);
			this.headerLabel.TabIndex = 0;
			this.headerLabel.Text = "RotS Class Designer";
			this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// add
			// 
			this.add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.add.Location = new System.Drawing.Point(474, 3);
			this.add.Name = "add";
			this.add.Size = new System.Drawing.Size(60, 24);
			this.add.TabIndex = 2;
			this.add.Text = "&Add";
			this.add.UseVisualStyleBackColor = true;
			this.add.Click += new System.EventHandler(this.add_Click);
			// 
			// delete
			// 
			this.delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.delete.Location = new System.Drawing.Point(549, 3);
			this.delete.Name = "delete";
			this.delete.Size = new System.Drawing.Size(60, 24);
			this.delete.TabIndex = 3;
			this.delete.Text = "&Delete";
			this.delete.UseVisualStyleBackColor = true;
			this.delete.Click += new System.EventHandler(this.delete_Click);
			// 
			// selectedProfile
			// 
			this.selectedProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.selectedProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectedProfile.FormattingEnabled = true;
			this.selectedProfile.Location = new System.Drawing.Point(165, 3);
			this.selectedProfile.Name = "selectedProfile";
			this.selectedProfile.Size = new System.Drawing.Size(294, 21);
			this.selectedProfile.TabIndex = 1;
			this.selectedProfile.SelectedIndexChanged += new System.EventHandler(this.selectedProfile_SelectedIndexChanged);
			this.selectedProfile.Validating += new System.ComponentModel.CancelEventHandler(this.selectedClass_Validating);
			// 
			// selectedClassLabel
			// 
			this.selectedClassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.selectedClassLabel.Location = new System.Drawing.Point(15, 0);
			this.selectedClassLabel.Name = "selectedClassLabel";
			this.selectedClassLabel.Size = new System.Drawing.Size(144, 23);
			this.selectedClassLabel.TabIndex = 0;
			this.selectedClassLabel.Text = "Class:";
			this.selectedClassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// buttonPanel
			// 
			this.buttonPanel.Controls.Add(this.copy);
			this.buttonPanel.Controls.Add(this.pointsRemaining);
			this.buttonPanel.Controls.Add(this.pointsRemainingLabel);
			this.buttonPanel.Controls.Add(this.clear);
			this.buttonPanel.Controls.Add(this.close);
			this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.buttonPanel.Location = new System.Drawing.Point(0, 530);
			this.buttonPanel.Name = "buttonPanel";
			this.buttonPanel.Size = new System.Drawing.Size(624, 31);
			this.buttonPanel.TabIndex = 5;
			// 
			// copy
			// 
			this.copy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.copy.Location = new System.Drawing.Point(354, 4);
			this.copy.Name = "copy";
			this.copy.Size = new System.Drawing.Size(85, 24);
			this.copy.TabIndex = 2;
			this.copy.Text = "Cop&y";
			this.copy.UseVisualStyleBackColor = true;
			this.copy.Click += new System.EventHandler(this.copy_Click);
			// 
			// pointsRemaining
			// 
			this.pointsRemaining.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pointsRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pointsRemaining.Location = new System.Drawing.Point(171, 4);
			this.pointsRemaining.Name = "pointsRemaining";
			this.pointsRemaining.Size = new System.Drawing.Size(160, 24);
			this.pointsRemaining.TabIndex = 1;
			this.pointsRemaining.Text = "150";
			this.pointsRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pointsRemainingLabel
			// 
			this.pointsRemainingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pointsRemainingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pointsRemainingLabel.Location = new System.Drawing.Point(8, 4);
			this.pointsRemainingLabel.Name = "pointsRemainingLabel";
			this.pointsRemainingLabel.Size = new System.Drawing.Size(160, 24);
			this.pointsRemainingLabel.TabIndex = 0;
			this.pointsRemainingLabel.Text = "Points Remaining:";
			this.pointsRemainingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// clear
			// 
			this.clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.clear.Location = new System.Drawing.Point(445, 4);
			this.clear.Name = "clear";
			this.clear.Size = new System.Drawing.Size(85, 24);
			this.clear.TabIndex = 3;
			this.clear.Text = "C&lear";
			this.clear.UseVisualStyleBackColor = true;
			this.clear.Click += new System.EventHandler(this.clear_Click);
			// 
			// close
			// 
			this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.close.Location = new System.Drawing.Point(536, 4);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(85, 24);
			this.close.TabIndex = 4;
			this.close.Text = "&Close";
			this.close.UseVisualStyleBackColor = true;
			this.close.Click += new System.EventHandler(this.close_Click);
			// 
			// raceFlowLayoutPanel
			// 
			this.raceFlowLayoutPanel.AutoSize = true;
			this.raceFlowLayoutPanel.Controls.Add(this.whitieRadio);
			this.raceFlowLayoutPanel.Controls.Add(this.urukHaiRadio);
			this.raceFlowLayoutPanel.Controls.Add(this.orcRadio);
			this.raceFlowLayoutPanel.Location = new System.Drawing.Point(165, 35);
			this.raceFlowLayoutPanel.Name = "raceFlowLayoutPanel";
			this.raceFlowLayoutPanel.Size = new System.Drawing.Size(207, 26);
			this.raceFlowLayoutPanel.TabIndex = 5;
			// 
			// whitieRadio
			// 
			this.whitieRadio.AutoSize = true;
			this.whitieRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.whitieRadio.Location = new System.Drawing.Point(3, 3);
			this.whitieRadio.Name = "whitieRadio";
			this.whitieRadio.Size = new System.Drawing.Size(63, 20);
			this.whitieRadio.TabIndex = 0;
			this.whitieRadio.TabStop = true;
			this.whitieRadio.Text = "Whitie";
			this.whitieRadio.UseVisualStyleBackColor = true;
			this.whitieRadio.CheckedChanged += new System.EventHandler(this.raceRadio_CheckedChanged);
			// 
			// urukHaiRadio
			// 
			this.urukHaiRadio.AutoSize = true;
			this.urukHaiRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.urukHaiRadio.Location = new System.Drawing.Point(72, 3);
			this.urukHaiRadio.Name = "urukHaiRadio";
			this.urukHaiRadio.Size = new System.Drawing.Size(79, 20);
			this.urukHaiRadio.TabIndex = 1;
			this.urukHaiRadio.TabStop = true;
			this.urukHaiRadio.Text = "Uruk-Hai";
			this.urukHaiRadio.UseVisualStyleBackColor = true;
			this.urukHaiRadio.CheckedChanged += new System.EventHandler(this.raceRadio_CheckedChanged);
			// 
			// orcRadio
			// 
			this.orcRadio.AutoSize = true;
			this.orcRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.orcRadio.Location = new System.Drawing.Point(157, 3);
			this.orcRadio.Name = "orcRadio";
			this.orcRadio.Size = new System.Drawing.Size(47, 20);
			this.orcRadio.TabIndex = 2;
			this.orcRadio.TabStop = true;
			this.orcRadio.Text = "Orc";
			this.orcRadio.UseVisualStyleBackColor = true;
			this.orcRadio.CheckedChanged += new System.EventHandler(this.raceRadio_CheckedChanged);
			// 
			// raceLabel
			// 
			this.raceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.raceLabel.Location = new System.Drawing.Point(15, 32);
			this.raceLabel.Name = "raceLabel";
			this.raceLabel.Size = new System.Drawing.Size(144, 23);
			this.raceLabel.TabIndex = 4;
			this.raceLabel.Text = "Race:";
			this.raceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// menuStrip
			// 
			this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(624, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.closeToolStripMenuItem.Text = "Close";
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.close_Click);
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetClassesToolStripMenuItem});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.toolsToolStripMenuItem.Text = "Tools";
			// 
			// resetClassesToolStripMenuItem
			// 
			this.resetClassesToolStripMenuItem.Name = "resetClassesToolStripMenuItem";
			this.resetClassesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.resetClassesToolStripMenuItem.Text = "Reset Classes";
			this.resetClassesToolStripMenuItem.Click += new System.EventHandler(this.resetClassesToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.aboutToolStripMenuItem.Text = "About...";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// modifiedMage
			// 
			this.modifiedMage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.modifiedMage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.modifiedMage.Location = new System.Drawing.Point(465, 107);
			this.modifiedMage.MaxLength = 3;
			this.modifiedMage.Name = "modifiedMage";
			this.modifiedMage.ReadOnly = true;
			this.modifiedMage.Size = new System.Drawing.Size(144, 22);
			this.modifiedMage.TabIndex = 18;
			this.modifiedMage.TabStop = false;
			// 
			// modifiedMystic
			// 
			this.modifiedMystic.Dock = System.Windows.Forms.DockStyle.Fill;
			this.modifiedMystic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.modifiedMystic.Location = new System.Drawing.Point(465, 79);
			this.modifiedMystic.MaxLength = 3;
			this.modifiedMystic.Name = "modifiedMystic";
			this.modifiedMystic.ReadOnly = true;
			this.modifiedMystic.Size = new System.Drawing.Size(144, 22);
			this.modifiedMystic.TabIndex = 14;
			this.modifiedMystic.TabStop = false;
			// 
			// modifiedRanger
			// 
			this.modifiedRanger.Dock = System.Windows.Forms.DockStyle.Fill;
			this.modifiedRanger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.modifiedRanger.Location = new System.Drawing.Point(465, 51);
			this.modifiedRanger.MaxLength = 3;
			this.modifiedRanger.Name = "modifiedRanger";
			this.modifiedRanger.ReadOnly = true;
			this.modifiedRanger.Size = new System.Drawing.Size(144, 22);
			this.modifiedRanger.TabIndex = 10;
			this.modifiedRanger.TabStop = false;
			// 
			// modifiedWarrior
			// 
			this.modifiedWarrior.Dock = System.Windows.Forms.DockStyle.Fill;
			this.modifiedWarrior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.modifiedWarrior.Location = new System.Drawing.Point(465, 23);
			this.modifiedWarrior.MaxLength = 3;
			this.modifiedWarrior.Name = "modifiedWarrior";
			this.modifiedWarrior.ReadOnly = true;
			this.modifiedWarrior.Size = new System.Drawing.Size(144, 22);
			this.modifiedWarrior.TabIndex = 6;
			this.modifiedWarrior.TabStop = false;
			// 
			// modifiedLevelLabel
			// 
			this.modifiedLevelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.modifiedLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.modifiedLevelLabel.Location = new System.Drawing.Point(465, 0);
			this.modifiedLevelLabel.Name = "modifiedLevelLabel";
			this.modifiedLevelLabel.Size = new System.Drawing.Size(144, 20);
			this.modifiedLevelLabel.TabIndex = 2;
			this.modifiedLevelLabel.Text = "Modified Level";
			this.modifiedLevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// mageLevel
			// 
			this.mageLevel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mageLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mageLevel.Location = new System.Drawing.Point(165, 107);
			this.mageLevel.MaxLength = 3;
			this.mageLevel.Name = "mageLevel";
			this.mageLevel.Size = new System.Drawing.Size(144, 22);
			this.mageLevel.TabIndex = 16;
			this.mageLevel.Validating += new System.ComponentModel.CancelEventHandler(this.classLevel_Validating);
			// 
			// mageLabel
			// 
			this.mageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mageLabel.Location = new System.Drawing.Point(15, 104);
			this.mageLabel.Name = "mageLabel";
			this.mageLabel.Size = new System.Drawing.Size(144, 28);
			this.mageLabel.TabIndex = 15;
			this.mageLabel.Text = "Mage:";
			this.mageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// mysticLevel
			// 
			this.mysticLevel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mysticLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mysticLevel.Location = new System.Drawing.Point(165, 79);
			this.mysticLevel.MaxLength = 3;
			this.mysticLevel.Name = "mysticLevel";
			this.mysticLevel.Size = new System.Drawing.Size(144, 22);
			this.mysticLevel.TabIndex = 12;
			this.mysticLevel.Validating += new System.ComponentModel.CancelEventHandler(this.classLevel_Validating);
			// 
			// mysticLabel
			// 
			this.mysticLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mysticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mysticLabel.Location = new System.Drawing.Point(15, 76);
			this.mysticLabel.Name = "mysticLabel";
			this.mysticLabel.Size = new System.Drawing.Size(144, 28);
			this.mysticLabel.TabIndex = 11;
			this.mysticLabel.Text = "Mystic";
			this.mysticLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// warriorLevel
			// 
			this.warriorLevel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.warriorLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.warriorLevel.Location = new System.Drawing.Point(165, 23);
			this.warriorLevel.MaxLength = 3;
			this.warriorLevel.Name = "warriorLevel";
			this.warriorLevel.Size = new System.Drawing.Size(144, 22);
			this.warriorLevel.TabIndex = 4;
			this.warriorLevel.Validating += new System.ComponentModel.CancelEventHandler(this.classLevel_Validating);
			// 
			// rangerLevel
			// 
			this.rangerLevel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rangerLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rangerLevel.Location = new System.Drawing.Point(165, 51);
			this.rangerLevel.MaxLength = 3;
			this.rangerLevel.Name = "rangerLevel";
			this.rangerLevel.Size = new System.Drawing.Size(144, 22);
			this.rangerLevel.TabIndex = 8;
			this.rangerLevel.Validating += new System.ComponentModel.CancelEventHandler(this.classLevel_Validating);
			// 
			// rangerLabel
			// 
			this.rangerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rangerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rangerLabel.Location = new System.Drawing.Point(15, 48);
			this.rangerLabel.Name = "rangerLabel";
			this.rangerLabel.Size = new System.Drawing.Size(144, 28);
			this.rangerLabel.TabIndex = 7;
			this.rangerLabel.Text = "Ranger:";
			this.rangerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// levelLabel
			// 
			this.levelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.levelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.levelLabel.Location = new System.Drawing.Point(165, 0);
			this.levelLabel.Name = "levelLabel";
			this.levelLabel.Size = new System.Drawing.Size(144, 20);
			this.levelLabel.TabIndex = 0;
			this.levelLabel.Text = "Level";
			this.levelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// warriorLabel
			// 
			this.warriorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.warriorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.warriorLabel.Location = new System.Drawing.Point(15, 20);
			this.warriorLabel.Name = "warriorLabel";
			this.warriorLabel.Size = new System.Drawing.Size(144, 28);
			this.warriorLabel.TabIndex = 3;
			this.warriorLabel.Text = "Warrior:";
			this.warriorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// pointsLabel
			// 
			this.pointsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pointsLabel.Location = new System.Drawing.Point(315, 0);
			this.pointsLabel.Name = "pointsLabel";
			this.pointsLabel.Size = new System.Drawing.Size(144, 20);
			this.pointsLabel.TabIndex = 1;
			this.pointsLabel.Text = "Points";
			this.pointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// rangerPoints
			// 
			this.rangerPoints.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rangerPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rangerPoints.Location = new System.Drawing.Point(315, 51);
			this.rangerPoints.MaxLength = 3;
			this.rangerPoints.Name = "rangerPoints";
			this.rangerPoints.Size = new System.Drawing.Size(144, 22);
			this.rangerPoints.TabIndex = 9;
			this.rangerPoints.Validating += new System.ComponentModel.CancelEventHandler(this.classPoints_Validating);
			// 
			// magePoints
			// 
			this.magePoints.Dock = System.Windows.Forms.DockStyle.Fill;
			this.magePoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.magePoints.Location = new System.Drawing.Point(315, 107);
			this.magePoints.MaxLength = 3;
			this.magePoints.Name = "magePoints";
			this.magePoints.Size = new System.Drawing.Size(144, 22);
			this.magePoints.TabIndex = 17;
			this.magePoints.Validating += new System.ComponentModel.CancelEventHandler(this.classPoints_Validating);
			// 
			// warriorPoints
			// 
			this.warriorPoints.Dock = System.Windows.Forms.DockStyle.Fill;
			this.warriorPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.warriorPoints.Location = new System.Drawing.Point(315, 23);
			this.warriorPoints.MaxLength = 3;
			this.warriorPoints.Name = "warriorPoints";
			this.warriorPoints.Size = new System.Drawing.Size(144, 22);
			this.warriorPoints.TabIndex = 5;
			this.warriorPoints.Validating += new System.ComponentModel.CancelEventHandler(this.classPoints_Validating);
			// 
			// mysticPoints
			// 
			this.mysticPoints.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mysticPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mysticPoints.Location = new System.Drawing.Point(315, 79);
			this.mysticPoints.MaxLength = 3;
			this.mysticPoints.Name = "mysticPoints";
			this.mysticPoints.Size = new System.Drawing.Size(144, 22);
			this.mysticPoints.TabIndex = 13;
			this.mysticPoints.Validating += new System.ComponentModel.CancelEventHandler(this.classPoints_Validating);
			// 
			// skillsGridView
			// 
			this.skillsGridView.AllowUserToAddRows = false;
			this.skillsGridView.AllowUserToDeleteRows = false;
			this.skillsGridView.AllowUserToResizeColumns = false;
			this.skillsGridView.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
			this.skillsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.skillsGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.skillsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.skillNameColumn,
            this.skillClassColumn,
            this.skillLevelColumn,
            this.skillSpecializationTypeColumn,
            this.skillRaceColumn});
			this.skillsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.skillsGridView.Location = new System.Drawing.Point(18, 3);
			this.skillsGridView.Name = "skillsGridView";
			this.skillsGridView.ReadOnly = true;
			this.skillsGridView.Size = new System.Drawing.Size(588, 254);
			this.skillsGridView.TabIndex = 0;
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.ColumnCount = 6;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel.Controls.Add(this.pointsLabel, 3, 0);
			this.tableLayoutPanel.Controls.Add(this.modifiedLevelLabel, 4, 0);
			this.tableLayoutPanel.Controls.Add(this.magePoints, 3, 4);
			this.tableLayoutPanel.Controls.Add(this.modifiedMage, 4, 4);
			this.tableLayoutPanel.Controls.Add(this.rangerPoints, 3, 2);
			this.tableLayoutPanel.Controls.Add(this.mysticPoints, 3, 3);
			this.tableLayoutPanel.Controls.Add(this.modifiedRanger, 4, 2);
			this.tableLayoutPanel.Controls.Add(this.modifiedMystic, 4, 3);
			this.tableLayoutPanel.Controls.Add(this.rangerLabel, 1, 2);
			this.tableLayoutPanel.Controls.Add(this.warriorLabel, 1, 1);
			this.tableLayoutPanel.Controls.Add(this.modifiedWarrior, 4, 1);
			this.tableLayoutPanel.Controls.Add(this.mageLabel, 1, 4);
			this.tableLayoutPanel.Controls.Add(this.levelLabel, 2, 0);
			this.tableLayoutPanel.Controls.Add(this.warriorLevel, 2, 1);
			this.tableLayoutPanel.Controls.Add(this.rangerLevel, 2, 2);
			this.tableLayoutPanel.Controls.Add(this.mysticLevel, 2, 3);
			this.tableLayoutPanel.Controls.Add(this.mageLevel, 2, 4);
			this.tableLayoutPanel.Controls.Add(this.warriorPoints, 3, 1);
			this.tableLayoutPanel.Controls.Add(this.mysticLabel, 1, 3);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
			this.tableLayoutPanel.Location = new System.Drawing.Point(0, 138);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 5;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(624, 132);
			this.tableLayoutPanel.TabIndex = 3;
			// 
			// skillNameColumn
			// 
			this.skillNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.skillNameColumn.DataPropertyName = "SkillName";
			this.skillNameColumn.HeaderText = "Name";
			this.skillNameColumn.Name = "skillNameColumn";
			this.skillNameColumn.ReadOnly = true;
			this.skillNameColumn.Width = 60;
			// 
			// skillClassColumn
			// 
			this.skillClassColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.skillClassColumn.DataPropertyName = "Class";
			this.skillClassColumn.HeaderText = "Class";
			this.skillClassColumn.Name = "skillClassColumn";
			this.skillClassColumn.ReadOnly = true;
			this.skillClassColumn.Width = 57;
			// 
			// skillLevelColumn
			// 
			this.skillLevelColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.skillLevelColumn.DataPropertyName = "SkillLevel";
			this.skillLevelColumn.HeaderText = "Level";
			this.skillLevelColumn.Name = "skillLevelColumn";
			this.skillLevelColumn.ReadOnly = true;
			this.skillLevelColumn.Width = 58;
			// 
			// skillSpecializationTypeColumn
			// 
			this.skillSpecializationTypeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.skillSpecializationTypeColumn.DataPropertyName = "SpecializationType";
			this.skillSpecializationTypeColumn.HeaderText = "Specialization Type";
			this.skillSpecializationTypeColumn.MinimumWidth = 20;
			this.skillSpecializationTypeColumn.Name = "skillSpecializationTypeColumn";
			this.skillSpecializationTypeColumn.ReadOnly = true;
			this.skillSpecializationTypeColumn.Width = 124;
			// 
			// skillRaceColumn
			// 
			this.skillRaceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.skillRaceColumn.DataPropertyName = "Race";
			this.skillRaceColumn.HeaderText = "Race";
			this.skillRaceColumn.Name = "skillRaceColumn";
			this.skillRaceColumn.ReadOnly = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.ColumnCount = 6;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.delete, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.add, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.raceFlowLayoutPanel, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.raceLabel, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.selectedProfile, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.selectedClassLabel, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 74);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(624, 64);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.AutoSize = true;
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 600F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.headerLabel, 1, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 24);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(624, 50);
			this.tableLayoutPanel2.TabIndex = 1;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 3;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
			this.tableLayoutPanel3.Controls.Add(this.skillsGridView, 1, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 270);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.Size = new System.Drawing.Size(624, 260);
			this.tableLayoutPanel3.TabIndex = 4;
			// 
			// RCDForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 561);
			this.Controls.Add(this.tableLayoutPanel3);
			this.Controls.Add(this.buttonPanel);
			this.Controls.Add(this.tableLayoutPanel);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Controls.Add(this.menuStrip);
			this.MainMenuStrip = this.menuStrip;
			this.MinimumSize = new System.Drawing.Size(640, 400);
			this.Name = "RCDForm";
			this.Text = "SimpleRCD";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
			this.buttonPanel.ResumeLayout(false);
			this.raceFlowLayoutPanel.ResumeLayout(false);
			this.raceFlowLayoutPanel.PerformLayout();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.skillsGridView)).EndInit();
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label headerLabel;
		private System.Windows.Forms.ComboBox selectedProfile;
		private System.Windows.Forms.Label selectedClassLabel;
		private System.Windows.Forms.Panel buttonPanel;
		private System.Windows.Forms.Button close;
		private System.Windows.Forms.FlowLayoutPanel raceFlowLayoutPanel;
		private System.Windows.Forms.RadioButton whitieRadio;
		private System.Windows.Forms.RadioButton urukHaiRadio;
		private System.Windows.Forms.RadioButton orcRadio;
		private System.Windows.Forms.Label raceLabel;
		private System.Windows.Forms.Label pointsRemainingLabel;
		private System.Windows.Forms.Button clear;
		private System.Windows.Forms.Button delete;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.Label pointsRemaining;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem resetClassesToolStripMenuItem;
		private System.Windows.Forms.TextBox modifiedMage;
		private System.Windows.Forms.TextBox modifiedMystic;
		private System.Windows.Forms.TextBox modifiedRanger;
		private System.Windows.Forms.TextBox modifiedWarrior;
		private System.Windows.Forms.Label modifiedLevelLabel;
		private System.Windows.Forms.TextBox mageLevel;
		private System.Windows.Forms.Label mageLabel;
		private System.Windows.Forms.TextBox mysticLevel;
		private System.Windows.Forms.Label mysticLabel;
		private System.Windows.Forms.TextBox warriorLevel;
		private System.Windows.Forms.TextBox rangerLevel;
		private System.Windows.Forms.Label rangerLabel;
		private System.Windows.Forms.Label levelLabel;
		private System.Windows.Forms.Label warriorLabel;
		private System.Windows.Forms.Label pointsLabel;
		private System.Windows.Forms.DataGridView skillsGridView;
		private System.Windows.Forms.TextBox rangerPoints;
		private System.Windows.Forms.TextBox magePoints;
		private System.Windows.Forms.TextBox warriorPoints;
		private System.Windows.Forms.TextBox mysticPoints;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.Button add;
		private System.Windows.Forms.Button copy;
		private System.Windows.Forms.DataGridViewTextBoxColumn skillNameColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn skillClassColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn skillLevelColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn skillSpecializationTypeColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn skillRaceColumn;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
	}
}