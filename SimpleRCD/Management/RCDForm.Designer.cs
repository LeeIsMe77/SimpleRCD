namespace SimpleRCD.Management {
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
			this.headerLabel = new System.Windows.Forms.Label();
			this.modePanel = new System.Windows.Forms.Panel();
			this.deleteClass = new System.Windows.Forms.Button();
			this.selectedClass = new System.Windows.Forms.ComboBox();
			this.selectedClassLabel = new System.Windows.Forms.Label();
			this.buttonPanel = new System.Windows.Forms.Panel();
			this.pointsRemaining = new System.Windows.Forms.Label();
			this.pointsRemainingLabel = new System.Windows.Forms.Label();
			this.clear = new System.Windows.Forms.Button();
			this.close = new System.Windows.Forms.Button();
			this.raceFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.whitieRadio = new System.Windows.Forms.RadioButton();
			this.urukHaiRadio = new System.Windows.Forms.RadioButton();
			this.orcRadio = new System.Windows.Forms.RadioButton();
			this.raceLabel = new System.Windows.Forms.Label();
			this.racePanel = new System.Windows.Forms.Panel();
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
			this.magePoints = new System.Windows.Forms.TextBox();
			this.mageLevel = new System.Windows.Forms.TextBox();
			this.mysticPoints = new System.Windows.Forms.TextBox();
			this.mageLabel = new System.Windows.Forms.Label();
			this.rangerPoints = new System.Windows.Forms.TextBox();
			this.mysticLevel = new System.Windows.Forms.TextBox();
			this.mysticLabel = new System.Windows.Forms.Label();
			this.warriorLevel = new System.Windows.Forms.TextBox();
			this.rangerLevel = new System.Windows.Forms.TextBox();
			this.rangerLabel = new System.Windows.Forms.Label();
			this.levelLabel = new System.Windows.Forms.Label();
			this.warriorPoints = new System.Windows.Forms.TextBox();
			this.warriorLabel = new System.Windows.Forms.Label();
			this.pointsLabel = new System.Windows.Forms.Label();
			this.coefPanel = new System.Windows.Forms.Panel();
			this.skillsGridView = new System.Windows.Forms.DataGridView();
			this.modePanel.SuspendLayout();
			this.buttonPanel.SuspendLayout();
			this.raceFlowLayoutPanel.SuspendLayout();
			this.racePanel.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.coefPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.skillsGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// headerLabel
			// 
			this.headerLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.headerLabel.Location = new System.Drawing.Point(0, 24);
			this.headerLabel.Name = "headerLabel";
			this.headerLabel.Size = new System.Drawing.Size(657, 57);
			this.headerLabel.TabIndex = 1;
			this.headerLabel.Text = "RotS Class Designer";
			this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// modePanel
			// 
			this.modePanel.Controls.Add(this.deleteClass);
			this.modePanel.Controls.Add(this.selectedClass);
			this.modePanel.Controls.Add(this.selectedClassLabel);
			this.modePanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.modePanel.Location = new System.Drawing.Point(0, 81);
			this.modePanel.Name = "modePanel";
			this.modePanel.Size = new System.Drawing.Size(657, 28);
			this.modePanel.TabIndex = 2;
			// 
			// deleteClass
			// 
			this.deleteClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.deleteClass.Location = new System.Drawing.Point(546, 3);
			this.deleteClass.Name = "deleteClass";
			this.deleteClass.Size = new System.Drawing.Size(89, 21);
			this.deleteClass.TabIndex = 2;
			this.deleteClass.Text = "&Delete Class";
			this.deleteClass.UseVisualStyleBackColor = true;
			this.deleteClass.Click += new System.EventHandler(this.deleteClass_Click);
			// 
			// selectedClass
			// 
			this.selectedClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.selectedClass.FormattingEnabled = true;
			this.selectedClass.Location = new System.Drawing.Point(180, 3);
			this.selectedClass.Name = "selectedClass";
			this.selectedClass.Size = new System.Drawing.Size(360, 21);
			this.selectedClass.TabIndex = 1;
			this.selectedClass.TextChanged += new System.EventHandler(this.selectedClass_TextChanged);
			this.selectedClass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.control_MouseUp);
			this.selectedClass.Validating += new System.ComponentModel.CancelEventHandler(this.selectedClass_Validating);
			// 
			// selectedClassLabel
			// 
			this.selectedClassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.selectedClassLabel.Location = new System.Drawing.Point(13, 1);
			this.selectedClassLabel.Name = "selectedClassLabel";
			this.selectedClassLabel.Size = new System.Drawing.Size(161, 23);
			this.selectedClassLabel.TabIndex = 0;
			this.selectedClassLabel.Text = "Class:";
			this.selectedClassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// buttonPanel
			// 
			this.buttonPanel.Controls.Add(this.pointsRemaining);
			this.buttonPanel.Controls.Add(this.pointsRemainingLabel);
			this.buttonPanel.Controls.Add(this.clear);
			this.buttonPanel.Controls.Add(this.close);
			this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.buttonPanel.Location = new System.Drawing.Point(0, 517);
			this.buttonPanel.Name = "buttonPanel";
			this.buttonPanel.Size = new System.Drawing.Size(657, 37);
			this.buttonPanel.TabIndex = 6;
			// 
			// pointsRemaining
			// 
			this.pointsRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pointsRemaining.Location = new System.Drawing.Point(177, 7);
			this.pointsRemaining.Name = "pointsRemaining";
			this.pointsRemaining.Size = new System.Drawing.Size(160, 23);
			this.pointsRemaining.TabIndex = 1;
			this.pointsRemaining.Text = "150";
			this.pointsRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pointsRemainingLabel
			// 
			this.pointsRemainingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pointsRemainingLabel.Location = new System.Drawing.Point(14, 7);
			this.pointsRemainingLabel.Name = "pointsRemainingLabel";
			this.pointsRemainingLabel.Size = new System.Drawing.Size(160, 23);
			this.pointsRemainingLabel.TabIndex = 0;
			this.pointsRemainingLabel.Text = "Points Remaining:";
			this.pointsRemainingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// clear
			// 
			this.clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.clear.Location = new System.Drawing.Point(478, 3);
			this.clear.Name = "clear";
			this.clear.Size = new System.Drawing.Size(85, 31);
			this.clear.TabIndex = 2;
			this.clear.Text = "C&lear";
			this.clear.UseVisualStyleBackColor = true;
			this.clear.Click += new System.EventHandler(this.clear_Click);
			// 
			// close
			// 
			this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.close.Location = new System.Drawing.Point(569, 3);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(85, 31);
			this.close.TabIndex = 3;
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
			this.raceFlowLayoutPanel.Location = new System.Drawing.Point(180, 6);
			this.raceFlowLayoutPanel.Name = "raceFlowLayoutPanel";
			this.raceFlowLayoutPanel.Size = new System.Drawing.Size(207, 26);
			this.raceFlowLayoutPanel.TabIndex = 1;
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
			this.raceLabel.Location = new System.Drawing.Point(13, 6);
			this.raceLabel.Name = "raceLabel";
			this.raceLabel.Size = new System.Drawing.Size(161, 23);
			this.raceLabel.TabIndex = 0;
			this.raceLabel.Text = "Race:";
			this.raceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// racePanel
			// 
			this.racePanel.Controls.Add(this.raceFlowLayoutPanel);
			this.racePanel.Controls.Add(this.raceLabel);
			this.racePanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.racePanel.Location = new System.Drawing.Point(0, 109);
			this.racePanel.Name = "racePanel";
			this.racePanel.Size = new System.Drawing.Size(657, 34);
			this.racePanel.TabIndex = 3;
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(657, 24);
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
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
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
			this.resetClassesToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
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
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.aboutToolStripMenuItem.Text = "About...";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
			// 
			// modifiedMage
			// 
			this.modifiedMage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.modifiedMage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.modifiedMage.Location = new System.Drawing.Point(429, 119);
			this.modifiedMage.MaxLength = 3;
			this.modifiedMage.Name = "modifiedMage";
			this.modifiedMage.ReadOnly = true;
			this.modifiedMage.Size = new System.Drawing.Size(174, 22);
			this.modifiedMage.TabIndex = 18;
			this.modifiedMage.TabStop = false;
			// 
			// modifiedMystic
			// 
			this.modifiedMystic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.modifiedMystic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.modifiedMystic.Location = new System.Drawing.Point(429, 91);
			this.modifiedMystic.MaxLength = 3;
			this.modifiedMystic.Name = "modifiedMystic";
			this.modifiedMystic.ReadOnly = true;
			this.modifiedMystic.Size = new System.Drawing.Size(174, 22);
			this.modifiedMystic.TabIndex = 14;
			this.modifiedMystic.TabStop = false;
			// 
			// modifiedRanger
			// 
			this.modifiedRanger.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.modifiedRanger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.modifiedRanger.Location = new System.Drawing.Point(429, 63);
			this.modifiedRanger.MaxLength = 3;
			this.modifiedRanger.Name = "modifiedRanger";
			this.modifiedRanger.ReadOnly = true;
			this.modifiedRanger.Size = new System.Drawing.Size(174, 22);
			this.modifiedRanger.TabIndex = 10;
			this.modifiedRanger.TabStop = false;
			// 
			// modifiedWarrior
			// 
			this.modifiedWarrior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.modifiedWarrior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.modifiedWarrior.Location = new System.Drawing.Point(429, 35);
			this.modifiedWarrior.MaxLength = 3;
			this.modifiedWarrior.Name = "modifiedWarrior";
			this.modifiedWarrior.ReadOnly = true;
			this.modifiedWarrior.Size = new System.Drawing.Size(174, 22);
			this.modifiedWarrior.TabIndex = 6;
			this.modifiedWarrior.TabStop = false;
			// 
			// modifiedLevelLabel
			// 
			this.modifiedLevelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.modifiedLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.modifiedLevelLabel.Location = new System.Drawing.Point(429, 10);
			this.modifiedLevelLabel.Name = "modifiedLevelLabel";
			this.modifiedLevelLabel.Size = new System.Drawing.Size(174, 20);
			this.modifiedLevelLabel.TabIndex = 2;
			this.modifiedLevelLabel.Text = "Modified Level";
			this.modifiedLevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// magePoints
			// 
			this.magePoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.magePoints.Location = new System.Drawing.Point(310, 119);
			this.magePoints.MaxLength = 3;
			this.magePoints.Name = "magePoints";
			this.magePoints.ReadOnly = true;
			this.magePoints.Size = new System.Drawing.Size(101, 22);
			this.magePoints.TabIndex = 17;
			this.magePoints.TabStop = false;
			// 
			// mageLevel
			// 
			this.mageLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mageLevel.Location = new System.Drawing.Point(188, 119);
			this.mageLevel.MaxLength = 3;
			this.mageLevel.Name = "mageLevel";
			this.mageLevel.Size = new System.Drawing.Size(101, 22);
			this.mageLevel.TabIndex = 16;
			this.mageLevel.Validating += new System.ComponentModel.CancelEventHandler(this.classLevel_Validating);
			// 
			// mysticPoints
			// 
			this.mysticPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mysticPoints.Location = new System.Drawing.Point(310, 91);
			this.mysticPoints.MaxLength = 3;
			this.mysticPoints.Name = "mysticPoints";
			this.mysticPoints.ReadOnly = true;
			this.mysticPoints.Size = new System.Drawing.Size(101, 22);
			this.mysticPoints.TabIndex = 13;
			this.mysticPoints.TabStop = false;
			// 
			// mageLabel
			// 
			this.mageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mageLabel.Location = new System.Drawing.Point(48, 120);
			this.mageLabel.Name = "mageLabel";
			this.mageLabel.Size = new System.Drawing.Size(134, 20);
			this.mageLabel.TabIndex = 15;
			this.mageLabel.Text = "Mage:";
			this.mageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// rangerPoints
			// 
			this.rangerPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rangerPoints.Location = new System.Drawing.Point(310, 63);
			this.rangerPoints.MaxLength = 3;
			this.rangerPoints.Name = "rangerPoints";
			this.rangerPoints.ReadOnly = true;
			this.rangerPoints.Size = new System.Drawing.Size(101, 22);
			this.rangerPoints.TabIndex = 9;
			this.rangerPoints.TabStop = false;
			// 
			// mysticLevel
			// 
			this.mysticLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mysticLevel.Location = new System.Drawing.Point(188, 91);
			this.mysticLevel.MaxLength = 3;
			this.mysticLevel.Name = "mysticLevel";
			this.mysticLevel.Size = new System.Drawing.Size(101, 22);
			this.mysticLevel.TabIndex = 12;
			this.mysticLevel.Validating += new System.ComponentModel.CancelEventHandler(this.classLevel_Validating);
			// 
			// mysticLabel
			// 
			this.mysticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mysticLabel.Location = new System.Drawing.Point(48, 92);
			this.mysticLabel.Name = "mysticLabel";
			this.mysticLabel.Size = new System.Drawing.Size(134, 20);
			this.mysticLabel.TabIndex = 11;
			this.mysticLabel.Text = "Mystic";
			this.mysticLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// warriorLevel
			// 
			this.warriorLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.warriorLevel.Location = new System.Drawing.Point(188, 36);
			this.warriorLevel.MaxLength = 3;
			this.warriorLevel.Name = "warriorLevel";
			this.warriorLevel.Size = new System.Drawing.Size(101, 22);
			this.warriorLevel.TabIndex = 4;
			this.warriorLevel.Validating += new System.ComponentModel.CancelEventHandler(this.classLevel_Validating);
			// 
			// rangerLevel
			// 
			this.rangerLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rangerLevel.Location = new System.Drawing.Point(188, 63);
			this.rangerLevel.MaxLength = 3;
			this.rangerLevel.Name = "rangerLevel";
			this.rangerLevel.Size = new System.Drawing.Size(101, 22);
			this.rangerLevel.TabIndex = 8;
			this.rangerLevel.Validating += new System.ComponentModel.CancelEventHandler(this.classLevel_Validating);
			// 
			// rangerLabel
			// 
			this.rangerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rangerLabel.Location = new System.Drawing.Point(48, 65);
			this.rangerLabel.Name = "rangerLabel";
			this.rangerLabel.Size = new System.Drawing.Size(134, 20);
			this.rangerLabel.TabIndex = 7;
			this.rangerLabel.Text = "Ranger:";
			this.rangerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// levelLabel
			// 
			this.levelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.levelLabel.Location = new System.Drawing.Point(188, 10);
			this.levelLabel.Name = "levelLabel";
			this.levelLabel.Size = new System.Drawing.Size(101, 20);
			this.levelLabel.TabIndex = 0;
			this.levelLabel.Text = "Level";
			this.levelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// warriorPoints
			// 
			this.warriorPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.warriorPoints.Location = new System.Drawing.Point(310, 35);
			this.warriorPoints.MaxLength = 3;
			this.warriorPoints.Name = "warriorPoints";
			this.warriorPoints.ReadOnly = true;
			this.warriorPoints.Size = new System.Drawing.Size(101, 22);
			this.warriorPoints.TabIndex = 5;
			this.warriorPoints.TabStop = false;
			// 
			// warriorLabel
			// 
			this.warriorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.warriorLabel.Location = new System.Drawing.Point(48, 37);
			this.warriorLabel.Name = "warriorLabel";
			this.warriorLabel.Size = new System.Drawing.Size(134, 20);
			this.warriorLabel.TabIndex = 3;
			this.warriorLabel.Text = "Warrior:";
			this.warriorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// pointsLabel
			// 
			this.pointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pointsLabel.Location = new System.Drawing.Point(310, 10);
			this.pointsLabel.Name = "pointsLabel";
			this.pointsLabel.Size = new System.Drawing.Size(101, 20);
			this.pointsLabel.TabIndex = 1;
			this.pointsLabel.Text = "Points";
			this.pointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// coefPanel
			// 
			this.coefPanel.Controls.Add(this.modifiedLevelLabel);
			this.coefPanel.Controls.Add(this.modifiedMage);
			this.coefPanel.Controls.Add(this.pointsLabel);
			this.coefPanel.Controls.Add(this.modifiedMystic);
			this.coefPanel.Controls.Add(this.warriorLabel);
			this.coefPanel.Controls.Add(this.modifiedRanger);
			this.coefPanel.Controls.Add(this.warriorPoints);
			this.coefPanel.Controls.Add(this.modifiedWarrior);
			this.coefPanel.Controls.Add(this.levelLabel);
			this.coefPanel.Controls.Add(this.rangerLabel);
			this.coefPanel.Controls.Add(this.magePoints);
			this.coefPanel.Controls.Add(this.rangerLevel);
			this.coefPanel.Controls.Add(this.mageLevel);
			this.coefPanel.Controls.Add(this.warriorLevel);
			this.coefPanel.Controls.Add(this.mysticPoints);
			this.coefPanel.Controls.Add(this.mysticLabel);
			this.coefPanel.Controls.Add(this.mageLabel);
			this.coefPanel.Controls.Add(this.mysticLevel);
			this.coefPanel.Controls.Add(this.rangerPoints);
			this.coefPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.coefPanel.Location = new System.Drawing.Point(0, 143);
			this.coefPanel.Name = "coefPanel";
			this.coefPanel.Size = new System.Drawing.Size(657, 152);
			this.coefPanel.TabIndex = 4;
			// 
			// skillsGridView
			// 
			this.skillsGridView.AllowUserToAddRows = false;
			this.skillsGridView.AllowUserToDeleteRows = false;
			this.skillsGridView.AllowUserToResizeColumns = false;
			this.skillsGridView.AllowUserToResizeRows = false;
			this.skillsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.skillsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.skillsGridView.Location = new System.Drawing.Point(0, 295);
			this.skillsGridView.Name = "skillsGridView";
			this.skillsGridView.ReadOnly = true;
			this.skillsGridView.Size = new System.Drawing.Size(657, 222);
			this.skillsGridView.TabIndex = 5;
			// 
			// RCDForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(657, 554);
			this.Controls.Add(this.skillsGridView);
			this.Controls.Add(this.coefPanel);
			this.Controls.Add(this.racePanel);
			this.Controls.Add(this.modePanel);
			this.Controls.Add(this.headerLabel);
			this.Controls.Add(this.buttonPanel);
			this.Controls.Add(this.menuStrip);
			this.MainMenuStrip = this.menuStrip;
			this.MinimumSize = new System.Drawing.Size(600, 400);
			this.Name = "RCDForm";
			this.Text = "RotS Class Designer";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
			this.modePanel.ResumeLayout(false);
			this.buttonPanel.ResumeLayout(false);
			this.raceFlowLayoutPanel.ResumeLayout(false);
			this.raceFlowLayoutPanel.PerformLayout();
			this.racePanel.ResumeLayout(false);
			this.racePanel.PerformLayout();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.coefPanel.ResumeLayout(false);
			this.coefPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.skillsGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label headerLabel;
		private System.Windows.Forms.Panel modePanel;
		private System.Windows.Forms.ComboBox selectedClass;
		private System.Windows.Forms.Label selectedClassLabel;
		private System.Windows.Forms.Panel buttonPanel;
		private System.Windows.Forms.Button close;
		private System.Windows.Forms.FlowLayoutPanel raceFlowLayoutPanel;
		private System.Windows.Forms.RadioButton whitieRadio;
		private System.Windows.Forms.RadioButton urukHaiRadio;
		private System.Windows.Forms.RadioButton orcRadio;
		private System.Windows.Forms.Label raceLabel;
		private System.Windows.Forms.Panel racePanel;
		private System.Windows.Forms.Label pointsRemainingLabel;
		private System.Windows.Forms.Button clear;
		private System.Windows.Forms.Button deleteClass;
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
		private System.Windows.Forms.TextBox magePoints;
		private System.Windows.Forms.TextBox mageLevel;
		private System.Windows.Forms.TextBox mysticPoints;
		private System.Windows.Forms.Label mageLabel;
		private System.Windows.Forms.TextBox rangerPoints;
		private System.Windows.Forms.TextBox mysticLevel;
		private System.Windows.Forms.Label mysticLabel;
		private System.Windows.Forms.TextBox warriorLevel;
		private System.Windows.Forms.TextBox rangerLevel;
		private System.Windows.Forms.Label rangerLabel;
		private System.Windows.Forms.Label levelLabel;
		private System.Windows.Forms.TextBox warriorPoints;
		private System.Windows.Forms.Label warriorLabel;
		private System.Windows.Forms.Label pointsLabel;
		private System.Windows.Forms.Panel coefPanel;
		private System.Windows.Forms.DataGridView skillsGridView;
	}
}