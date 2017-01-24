namespace SimpleRCD.Management {

	#region Directives
	using System;
	using System.ComponentModel;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using System.Windows.Forms;
	using System.Xml.Linq;
	using Common;
	#endregion

	public partial class RCDForm
		: Form {

		#region Constants

		private const string CONFIGURATION_FILE_NAME = "RCDClasses.xml";

		#endregion

		#region Properties

		#region CharacterClassCollection

		private CharacterClassCollection _characterClasses;

		/// <summary>
		/// Gets the character classes.
		/// </summary>
		/// <value>The character classes.</value>
		public CharacterClassCollection CharacterClasses {
			get {
				if (_characterClasses == null) {
					_characterClasses = new CharacterClassCollection();
				}
				return _characterClasses;
			}
			private set { _characterClasses = value; }
		}

		#endregion

		#region CharacterRace
		
		/// <summary>
		/// Gets or sets the character race.
		/// </summary>
		/// <value>The character race.</value>
		public CharacterRace CharacterRace { get; set; }

		#endregion

		#region ConfigurationFilePath

		private string _configurationFileDirectory = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData, Environment.SpecialFolderOption.Create)}\\RotS Class Designer";

		/// <summary>
		/// Gets the configuration file path.
		/// </summary>
		/// <value>The configuration file path.</value>
		public string ConfigurationFilePath {
			get { return Path.Combine(_configurationFileDirectory, CONFIGURATION_FILE_NAME); }
		}

		#endregion

		#region OverrideSystemClassesCheckBox

		private CheckBox _overrideSystemButton;

		/// <summary>
		/// Gets the override system classes CheckBox.
		/// </summary>
		/// <value>The override system classes CheckBox.</value>
		private CheckBox OverrideSystemButton {
			get {
				if (_overrideSystemButton == null) {
					_overrideSystemButton = new CheckBox();
					_overrideSystemButton.Text = @"Override";
					_overrideSystemButton.CheckedChanged += this.overrideSystem_CheckedChanged;
					_overrideSystemButton.Dock = DockStyle.Fill;
				}
				return _overrideSystemButton;
			}
		}

		#endregion

		#endregion

		#region Constructor

		public RCDForm() {
			InitializeComponent();
			this.CharacterRace = CharacterRace.Whitie;
			this.whitieRadio.Checked = true;
		}

		#endregion

		#region Base Overrides

		/// <summary>
		/// Raises the <see cref="E:System.Windows.Forms.Form.Load" /> event.
		/// </summary>
		/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
		protected override void OnLoad(EventArgs e) {
			base.OnLoad(e);
			try {
				this.toolsToolStripMenuItem.DropDownItems.Add(new ToolStripControlHost(this.OverrideSystemButton));
				this.toolsToolStripMenuItem.AutoSize = true;
			}
			catch { }
			this.LoadConfiguration();
			this.BindCharacterClasses();

		}

		#endregion

		#region Methods

		#region CharacterClass Management

		/// <summary>
		/// Binds the character classes.
		/// </summary>
		private void BindCharacterClasses() {
			var selectedText = this.selectedClass.Text;
			try {
				this.selectedClass.DataSource = null;
				var bindingSource = new BindingSource(this.CharacterClasses, null);
				this.selectedClass.DataSource = bindingSource;
				this.selectedClass.DisplayMember = @"CharacterClassName";
			}
			catch (Exception caught) {
				MessageBox.Show(this, $"Failure binding classes: {caught.Message}", @"Failre Binding Classes...", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally {
				this.selectedClass.Text = string.IsNullOrWhiteSpace(selectedText)
					? this.CharacterClasses.Select(characterClass => characterClass.CharacterClassName).FirstOrDefault() ?? string.Empty
					: selectedText
					;
			}
		}

		/// <summary>
		/// Binds the character class to the user interface.
		/// </summary>
		/// <param name="characterClass">The character class.</param>
		private void BindCharacterClass(CharacterClass characterClass) {
			if (characterClass == null) return;

			this.warriorLevel.ReadOnly
				= this.rangerLevel.ReadOnly
				= this.mageLevel.ReadOnly
				= this.mysticLevel.ReadOnly
				= characterClass.IsSystemClass;

			this.deleteClass.Enabled
				= this.clear.Enabled
				= (this.OverrideSystemButton.Checked || !characterClass.IsSystemClass);

			var pointsAvailable = 150;
			var genericModifier = this.CharacterRace == CharacterRace.Orc ? .6m : 1.0m;

			this.warriorLevel.Text = characterClass.WarriorLevel.ToString();
			var warriorPoints = CharacterClassUtility.CalculatePointsUsed(characterClass.WarriorLevel);
			this.warriorPoints.Text = warriorPoints.ToString();
			var warriorModifier = this.CharacterRace == CharacterRace.Orc ? .6m : 1.0m;
			var modifiedWarriorLevel = ((int)Math.Floor(characterClass.WarriorLevel * genericModifier));
			this.modifiedWarrior.Text = modifiedWarriorLevel.ToString();
			pointsAvailable -= warriorPoints;

			this.rangerLevel.Text = characterClass.RangerLevel.ToString();
			var rangerPoints = CharacterClassUtility.CalculatePointsUsed(characterClass.RangerLevel);
			this.rangerPoints.Text = rangerPoints.ToString();
			var modifiedRangerLevel = ((int)Math.Floor(characterClass.RangerLevel * genericModifier));
			this.modifiedRanger.Text = modifiedRangerLevel.ToString();
			pointsAvailable -= rangerPoints;

			this.mysticLevel.Text = characterClass.MysticLevel.ToString();
			var mysticPoints = CharacterClassUtility.CalculatePointsUsed(characterClass.MysticLevel);
			this.mysticPoints.Text = mysticPoints.ToString();
			var modifiedMysticLevel = ((int)Math.Floor(characterClass.MysticLevel * genericModifier));
			this.modifiedMystic.Text = modifiedMysticLevel.ToString();
			pointsAvailable -= mysticPoints;

			this.mageLevel.Text = characterClass.MageLevel.ToString();
			var magePoints = CharacterClassUtility.CalculatePointsUsed(characterClass.MageLevel);
			this.magePoints.Text = magePoints.ToString();
			var modifiedMageLevel = (int)Math.Floor(this.CharacterRace == CharacterRace.UrukHai ? characterClass.MageLevel - 3 : characterClass.MageLevel * genericModifier);
			this.modifiedMage.Text = (modifiedMageLevel < 0 ? 0 : modifiedMageLevel).ToString();
			pointsAvailable -= magePoints;

			//var applicableSkills = RCDCache.MageSkills.Where(item => (this.CharacterRace & item.Race) == this.CharacterRace && item.SkillLevel <= modifiedMageLevel);
			//this.skillsGridView.DataSource = applicableSkills.ToList();

			this.DisplayPointsRemaining(pointsAvailable);
		}

		/// <summary>
		/// Displays the points remaining.
		/// </summary>
		/// <param name="pointsRemaining">The points remaining.</param>
		private void DisplayPointsRemaining(int pointsRemaining) {
			this.pointsRemaining.ForeColor = pointsRemaining < 0
				? Color.Red
				: Color.Green
				;

			this.pointsRemaining.Text = pointsRemaining.ToString();
		}

		/// <summary>
		/// Retrieves the selected class.
		/// </summary>
		/// <returns>CharacterClass.</returns>
		private CharacterClass RetrieveSelectedClass() {
			var selectedText = this.selectedClass.Text;
			if (string.IsNullOrWhiteSpace(selectedText)) return null;
			return this.CharacterClasses.FirstOrDefault(characterClass => characterClass.CharacterClassName.Equals(selectedText, StringComparison.OrdinalIgnoreCase));
		}

		#endregion

		#region Configuration

		/// <summary>
		/// Loads the configuration.
		/// </summary>
		private void LoadConfiguration() {
			var classCollection = new CharacterClassCollection();

			if (File.Exists(this.ConfigurationFilePath)) {

				try {
					var configurationFile = XElement.Load(this.ConfigurationFilePath);

					this.OverrideSystemButton.Checked = configurationFile.SafeAttributeValue<bool>(@"OverrideSystemClasses");
					this.CharacterRace = configurationFile.SafeAttributeValue<CharacterRace>(@"CharacterRace");
					(this.CharacterRace == CharacterRace.Whitie ? this.whitieRadio : this.CharacterRace == CharacterRace.UrukHai ? this.urukHaiRadio : this.orcRadio).Checked = true;

					var classElements = configurationFile?.Elements(@"Class");
					if (classElements != null) {
						foreach (var classElement in classElements) {

							var className = classElement.SafeAttributeValue<string>(@"ClassName");
							if (string.IsNullOrWhiteSpace(className)) {
								throw new Exception(@"The class name cannot be blank.");
							}

							if (classCollection.Any(characterClass => characterClass.CharacterClassName.Equals(className, StringComparison.OrdinalIgnoreCase))) {
								throw new Exception($"The class name {className} is a duplicate class.");
							}

							classCollection.Add(
								className,
								classElement.SafeAttributeValue<int>(@"WarriorLevel"),
								classElement.SafeAttributeValue<int>(@"RangerLevel"),
								classElement.SafeAttributeValue<int>(@"MysticLevel"),
								classElement.SafeAttributeValue<int>(@"MageLevel"),
								classElement.SafeAttributeValue<bool>(@"IsSystemClass")
							);
						}
					}
				}
				catch (Exception caught) {
					MessageBox.Show(this, $"Failure loading configuration: {caught.Message}", @"Failure Loading Configuration...", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else {
				classCollection.Add(@"Warrior", 30, 15, 12, 9, true);
				classCollection.Add(@"Ranger", 15, 30, 9, 12, true);
				classCollection.Add(@"Mystic", 12, 9, 30, 15, true);
				classCollection.Add(@"Mage", 9, 12, 15, 30, true);
				classCollection.Add(@"Baiken", 23, 27, 3, 9, true);
				classCollection.Add(@"Barbarian", 33, 15, 6, 0, true);
				classCollection.Add(@"Healer", 6, 0, 33, 15, true);
				classCollection.Add(@"Wizard", 6, 9, 12, 33, true);
				classCollection.Add(@"Buffer", 30, 20, 6, 3, true);
			}
			this.CharacterClasses = classCollection;
		}

		/// <summary>
		/// Saves the configuration.
		/// </summary>
		private void SaveConfiguration() {
			if (this.CharacterClasses == null) return;
			if (!Directory.Exists(_configurationFileDirectory)) {
				Directory.CreateDirectory(_configurationFileDirectory);
			}
			try {
				var exportElement = new XElement(
					@"RCDCharacterClasses",
					new XAttribute(@"OverrideSystemClasses", this.OverrideSystemButton.Checked),
					new XAttribute(@"CharacterRace", this.CharacterRace)
					);
				foreach (var characterClass in this.CharacterClasses) {
					exportElement.Add(
						new XElement(@"Class",
							new XAttribute(@"ClassName", characterClass.CharacterClassName),
							new XAttribute(@"MageLevel", characterClass.MageLevel),
							new XAttribute(@"MysticLevel", characterClass.MysticLevel),
							new XAttribute(@"RangerLevel", characterClass.RangerLevel),
							new XAttribute(@"WarriorLevel", characterClass.WarriorLevel),
							new XAttribute(@"IsSystemClass", characterClass.IsSystemClass)
							)
						);
				}
				exportElement.Save(this.ConfigurationFilePath);
			}
			catch (Exception caught) {
				MessageBox.Show(this, $"Failure saving configuration: {caught.Message}", @"Failure Saving Configuration...", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		#endregion

		#endregion

		#region Control Events

		/// <summary>
		/// Handles the Click event of the aboutToolStripMenuItem1 control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void aboutToolStripMenuItem1_Click(object sender, EventArgs e) {
			using (var form = new About()) {
				form.ShowDialog(this);
			}
		}

		/// <summary>
		/// Handles the Validating event of the classLevel control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.ComponentModel.CancelEventArgs"/> instance containing the event data.</param>
		/// <exception cref="Exception">The value {senderAsTextBox.Text}</exception>
		private void classLevel_Validating(object sender, CancelEventArgs e) {
			var desiredClass = this.RetrieveSelectedClass();
			if (desiredClass == null) return;

			var senderAsTextBox = sender as TextBox;
			if (senderAsTextBox == null) return;

			if (string.IsNullOrWhiteSpace(senderAsTextBox.Text)) {
				senderAsTextBox.Text = "0";
			}

			try {

				var classLevel = 0;
				if (!int.TryParse(senderAsTextBox.Text, NumberStyles.Integer, CultureInfo.InvariantCulture, out classLevel)) {
					throw new Exception($"The value {senderAsTextBox.Text} is not a valid character level.");
				}

				var coefficientPointsUsed = CharacterClassUtility.CalculatePointsUsed(classLevel).ToString(); ;
				if (sender == warriorLevel) {
					warriorPoints.Text = coefficientPointsUsed;
					desiredClass.WarriorLevel = classLevel;
				}
				else if (sender == rangerLevel) {
					rangerPoints.Text = coefficientPointsUsed;
					desiredClass.RangerLevel = classLevel;
				}
				else if (sender == mysticLevel) {
					mysticPoints.Text = coefficientPointsUsed;
					desiredClass.MysticLevel = classLevel;
				}
				else if (sender == mageLevel) {
					magePoints.Text = coefficientPointsUsed;
					desiredClass.MageLevel = classLevel;
				}

				this.DisplayPointsRemaining(desiredClass.CalculatePointsAvailable());
			}
			catch (Exception caught) {
				MessageBox.Show(this, $"Failure validating input: {caught.Message}", @"Failure Validating Input...", MessageBoxButtons.OK, MessageBoxIcon.Error);
				e.Cancel = true;
			}

		}

		/// <summary>
		/// Handles the Click event of the clear control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void clear_Click(object sender, EventArgs e) {
			var desiredClass = this.RetrieveSelectedClass();
			if (desiredClass == null) return;

			desiredClass.WarriorLevel = desiredClass.RangerLevel = desiredClass.MysticLevel = desiredClass.MageLevel = 0;
			this.BindCharacterClass(desiredClass);
		}

		/// <summary>
		/// Handles the Click event of the close control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void close_Click(object sender, EventArgs e) {
			this.Close();
		}

		/// <summary>
		/// Handles the MouseUp event of the control control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
		private void control_MouseUp(object sender, MouseEventArgs e) {
			if (e.Button == MouseButtons.Left) {
				(sender as TextBoxBase)?.SelectAll();
			}
		}

		/// <summary>
		/// Handles the Click event of the deleteClass control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void deleteClass_Click(object sender, EventArgs e) {
			var desiredClass = this.RetrieveSelectedClass();
			if (desiredClass == null) return;

			if (this.CharacterClasses.Contains(desiredClass)) {

				var response = MessageBox.Show(this, $"Are you SURE you want to delete the {desiredClass.CharacterClassName} class profile?", @"Are you SURE?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (response != DialogResult.Yes) return;

				var selectedIndexMinusOne = this.selectedClass.SelectedIndex - 1;
				this.selectedClass.SelectedIndex = selectedIndexMinusOne <= 0 ? 0 : selectedIndexMinusOne;
				this.CharacterClasses.Remove(desiredClass);
			}

			this.BindCharacterClasses();

		}

		/// <summary>
		/// Handles the CheckedChanged event of the overrideSystem control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void overrideSystem_CheckedChanged(object sender, EventArgs e) {
			this.BindCharacterClasses();
		}

		/// <summary>
		/// Handles the FormClosing event of the Main control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="FormClosingEventArgs" /> instance containing the event data.</param>
		private void Main_FormClosing(object sender, FormClosingEventArgs e) {
			try {
				this.SaveConfiguration();
			}
			catch { }
		}

		/// <summary>
		/// Races the radio checked changed.
		/// </summary>
		/// <param name="sender">The sender.</param>
		/// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
		private void raceRadio_CheckedChanged(object sender, EventArgs e) {
			this.CharacterRace = sender == whitieRadio
				? CharacterRace.Whitie
				: sender == urukHaiRadio
					? CharacterRace.UrukHai
					: CharacterRace.Orc
					;

			this.BindCharacterClass(this.RetrieveSelectedClass());
		}

		/// <summary>
		/// Handles the Click event of the resetClassesToolStripMenuItem control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void resetClassesToolStripMenuItem_Click(object sender, EventArgs e) {
			try {
				if (File.Exists(this.ConfigurationFilePath)) {
					File.Delete(this.ConfigurationFilePath);
				}
				this.LoadConfiguration();
				this.BindCharacterClasses();
			}
			catch (Exception caught) {
				MessageBox.Show(this, $"Failure re-generating classes: {caught.Message}", @"Failure Re-Generating Classes...", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// Handles the TextChanged event of the selectedClass control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void selectedClass_TextChanged(object sender, EventArgs e) {
			var desiredClass = this.RetrieveSelectedClass();
			if (desiredClass == null) return;
			this.BindCharacterClass(desiredClass);
		}

		/// <summary>
		/// Handles the Validating event of the selectedClass control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
		private void selectedClass_Validating(object sender, CancelEventArgs e) {
			var desiredClass = this.RetrieveSelectedClass();
			var selectedText = this.selectedClass.Text;
			try {
				if (desiredClass == null) {
					if (string.IsNullOrWhiteSpace(selectedText)) {
						e.Cancel = true;
						return;
					}

					var dataSourceAsClassCollection = (this.selectedClass.DataSource as BindingSource)?.DataSource as CharacterClassCollection;
					if (dataSourceAsClassCollection != null) {
						desiredClass = dataSourceAsClassCollection.Add(selectedText);
					}
				}
				this.BindCharacterClasses();
				this.BindCharacterClass(desiredClass);
			}
			finally {
				this.selectedClass.Text = selectedText;
			}
		}

		#endregion

	}

}
