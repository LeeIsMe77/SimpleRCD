namespace RCD.Client.Management {

	#region Directives
	using System;
	using System.ComponentModel;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using System.Runtime.InteropServices;
	using System.Windows.Forms;
	using System.Xml.Linq;
	using Common;
	using Extensions;
	#endregion

	public partial class RCDForm
		: Form {

		#region Constants

		private const string CONFIGURATION_FILE_NAME = "SimpleRCD.xml";

		#endregion

		#region Properties

		#region CharacterClassCollection

		private ClassProfileCollection _classProfiles;

		/// <summary>
		/// Gets the class profiles.
		/// </summary>
		/// <value>The class profiles.</value>
		public ClassProfileCollection ClassProfiles {
			get {
				if (_classProfiles == null) {
					_classProfiles = new ClassProfileCollection();
				}
				return _classProfiles;
			}
			private set { _classProfiles = value; }
		}

		#endregion

		#region CharacterRace

		/// <summary>
		/// Gets or sets the character race.
		/// </summary>
		/// <value>The character race.</value>
		public RaceType CharacterRace { get; set; }

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

		#endregion

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="RCDForm"/> class.
		/// </summary>
		public RCDForm() {
			InitializeComponent();
			this.Icon = RCD.Properties.Resources.AssemblyIcon;
			this.skillsGridView.AutoGenerateColumns = false;
			this.CharacterRace = RaceType.Light;
			this.whitieRadio.Checked = true;
			this.DisplayPointsRemaining(150);
		}

		#endregion

		#region Base Overrides

		/// <summary>
		/// Raises the <see cref="E:System.Windows.Forms.Form.Load" /> event.
		/// </summary>
		/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
		protected override void OnLoad(EventArgs e) {
			base.OnLoad(e);
			this.LoadConfiguration();
			this.BindClassProfiles();
		}

		#endregion

		#region Methods

		#region Character Profile Management

		/// <summary>
		/// Binds the skill grid.
		/// </summary>
		/// <param name="classProfile">The class profile.</param>
		private void BindSkillGrid(ClassProfile classProfile) {
			try {
				this.skillsGridView.DataSource = null;

				var warriorLevel = string.IsNullOrWhiteSpace(modifiedWarrior.Text) ? 0 : int.Parse(modifiedWarrior.Text);
				var rangerLevel = string.IsNullOrWhiteSpace(modifiedRanger.Text) ? 0 : int.Parse(modifiedRanger.Text);
				var mysticLevel = string.IsNullOrWhiteSpace(modifiedMystic.Text) ? 0 : int.Parse(modifiedMystic.Text);
				var mageLevel = string.IsNullOrWhiteSpace(modifiedMage.Text) ? 0 : int.Parse(modifiedMage.Text);

				var applicableSkills = RCDCache.Skills
					.Where(skill => (skill.Race & this.CharacterRace) == this.CharacterRace)
					.Where(skill => 
						(skill.Class == ClassType.Mage && skill.SkillLevel <= mageLevel) ||
						(skill.Class == ClassType.Warrior && skill.SkillLevel <= warriorLevel) ||
						(skill.Class == ClassType.Mystic && skill.SkillLevel <= mysticLevel) ||
						(skill.Class == ClassType.Ranger && skill.SkillLevel <= rangerLevel)
					)
					.OrderBy(skill => skill.Class)
					.ThenBy(skill => skill.SkillLevel)
					;

				this.skillsGridView.DataSource = applicableSkills.ToList();
			}
			catch (Exception caught) {
				MessageBox.Show(
					this,
					$"Failure binding skills: {caught.Message}",
					@"Failure Binding Skills...",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
					);
			}
		}

		/// <summary>
		/// Binds the class profiles.
		/// </summary>
		private void BindClassProfiles() {
			try {
				this.selectedProfile.DataSource = null;
				var bindingSource = new BindingSource(this.ClassProfiles, null);
				this.selectedProfile.DataSource = bindingSource;
				this.selectedProfile.DisplayMember = @"ClassProfileName";
			}
			catch (Exception caught) {
				MessageBox.Show(
					this, 
					$"Failure binding class profiles: {caught.Message}", 
					@"Failre Binding Class Profiles...", 
					MessageBoxButtons.OK, 
					MessageBoxIcon.Error
					);
			}
		}

		/// <summary>
		/// Binds the class profile.
		/// </summary>
		/// <param name="classProfile">The class profile.</param>
		private void BindClassProfile(ClassProfile classProfile) {
			//var currentProfile = this.selectedProfile.SelectedItem as ClassProfile;
			#region Set readonly and enabled properties in applicable controls
			this.warriorLevel.ReadOnly
				= this.rangerLevel.ReadOnly
				= this.mageLevel.ReadOnly
				= this.mysticLevel.ReadOnly
				= (classProfile == null || this.CharacterRace == RaceType.Orc);

			this.warriorLevel.Enabled
				= this.rangerLevel.Enabled
				= this.mageLevel.Enabled
				= this.mysticLevel.Enabled
				= (classProfile != null && this.CharacterRace != RaceType.Orc);

			this.warriorPoints.ReadOnly
				= this.rangerPoints.ReadOnly
				= this.magePoints.ReadOnly
				= this.mysticPoints.ReadOnly
				= classProfile == null;

			this.warriorPoints.Enabled
				= this.rangerPoints.Enabled
				= this.magePoints.Enabled
				= this.mysticPoints.Enabled
				= classProfile != null;

			this.clear.Enabled
				= this.delete.Enabled
				= classProfile != null;
			#endregion

			if (classProfile == null) {
				//If no profile has been passed, set a default Empty profile.
				classProfile = new ClassProfile("Empty", 0, 0, 0, 0);
			}

			var defaultModifier = this.CharacterRace == RaceType.Orc ? 2m / 3m : 1.0m;

			#region Warrior Row
			var warriorLevel = ClassProfileUtility.CalculateClassLevel(classProfile.WarriorPoints);
			this.warriorLevel.Text = ((int)Math.Floor(warriorLevel)).ToString();
			this.warriorPoints.Text = classProfile.WarriorPoints.ToString();
			var modifiedWarriorLevel = ((int)Math.Floor((decimal)warriorLevel * defaultModifier));
			this.modifiedWarrior.Text = modifiedWarriorLevel.ToString();
			#endregion

			#region Ranger Row
			var rangerLevel = ClassProfileUtility.CalculateClassLevel(classProfile.RangerPoints);
			this.rangerLevel.Text = ((int)Math.Floor(rangerLevel)).ToString();
			this.rangerPoints.Text = classProfile.RangerPoints.ToString();
			var modifiedRangerLevel = ((int)Math.Floor((decimal)rangerLevel * defaultModifier));
			this.modifiedRanger.Text = modifiedRangerLevel.ToString();
			#endregion

			#region Mystic Row
			var mysticLevel = ClassProfileUtility.CalculateClassLevel(classProfile.MysticPoints);
			this.mysticLevel.Text = ((int)Math.Floor(mysticLevel)).ToString();
			this.mysticPoints.Text = classProfile.MysticPoints.ToString();
			var modifiedMysticLevel = ((int)Math.Floor((decimal)mysticLevel * defaultModifier));
			this.modifiedMystic.Text = modifiedMysticLevel.ToString();
			#endregion

			#region Mage Row
			var mageLevel = ClassProfileUtility.CalculateClassLevel(classProfile.MagePoints);
			this.mageLevel.Text = ((int)Math.Floor(mageLevel)).ToString();
			this.magePoints.Text = classProfile.MagePoints.ToString();
			var modifiedMageLevel = (int)Math.Floor(this.CharacterRace == RaceType.Uruk ? (decimal)mageLevel - 3 : (decimal)mageLevel * defaultModifier);
			this.modifiedMage.Text = (modifiedMageLevel < 0 ? 0 : modifiedMageLevel).ToString();
			#endregion

			this.DisplayPointsRemaining(classProfile.CalculatePointsAvailable());
			this.BindSkillGrid(classProfile);
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

		#endregion

		#region Configuration

		/// <summary>
		/// Loads the configuration.
		/// </summary>
		private void LoadConfiguration() {
			var classCollection = new ClassProfileCollection();

			if (File.Exists(this.ConfigurationFilePath)) {

				try {
					var configurationFile = XElement.Load(this.ConfigurationFilePath);

					this.CharacterRace = configurationFile.SafeAttributeValue<RaceType>(@"CharacterRace");
					(this.CharacterRace == RaceType.Light ? this.whitieRadio : this.CharacterRace == RaceType.Uruk ? this.urukHaiRadio : this.orcRadio).Checked = true;

					var classElements = configurationFile?.Elements(@"ClassProfile");
					if (classElements != null) {
						foreach (var classElement in classElements) {

							var className = classElement.SafeAttributeValue<string>(@"ClassProfileName");
							if (string.IsNullOrWhiteSpace(className)) {
								throw new Exception(@"The class profile name cannot be blank.");
							}

							if (classCollection.Any(characterClass => characterClass.ClassProfileName.Equals(className, StringComparison.OrdinalIgnoreCase))) {
								throw new Exception($"The class profile name {className} is a duplicate class.");
							}

							classCollection.Add(
								className,
								classElement.SafeAttributeValue<int>(@"WarriorPoints"),
								classElement.SafeAttributeValue<int>(@"RangerPoints"),
								classElement.SafeAttributeValue<int>(@"MysticPoints"),
								classElement.SafeAttributeValue<int>(@"MagePoints")
							);
						}
					}
				}
				catch (Exception caught) {
					MessageBox.Show(this, $"Failure loading configuration: {caught.Message}", @"Failure Loading Configuration...", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else {
				//TODO: Add default classes based on points instead of levels.
				//classCollection.Add(@"Warrior", 30, 15, 12, 9, true);
				//classCollection.Add(@"Ranger", 15, 30, 9, 12, true);
				//classCollection.Add(@"Mystic", 12, 9, 30, 15, true);
				//classCollection.Add(@"Mage", 9, 12, 15, 30, true);
				//classCollection.Add(@"Baiken", 23, 27, 3, 9, true);
				//classCollection.Add(@"Barbarian", 33, 15, 6, 0, true);
				//classCollection.Add(@"Healer", 6, 0, 33, 15, true);
				//classCollection.Add(@"Wizard", 6, 9, 12, 33, true);
				//classCollection.Add(@"Buffer", 30, 20, 6, 3, true);
			}
			this.ClassProfiles = classCollection;
		}

		/// <summary>
		/// Saves the configuration.
		/// </summary>
		private void SaveConfiguration() {
			if (this.ClassProfiles == null) return;
			if (!Directory.Exists(_configurationFileDirectory)) {
				Directory.CreateDirectory(_configurationFileDirectory);
			}
			try {
				var exportElement = new XElement(
					@"ClassProfiles",
					new XAttribute(@"CharacterRace", this.CharacterRace)
					);
				foreach (var characterClass in this.ClassProfiles) {
					exportElement.Add(
						new XElement(@"ClassProfile",
							new XAttribute(@"ClassProfileName", characterClass.ClassProfileName),
							new XAttribute(@"MagePoints", characterClass.MagePoints),
							new XAttribute(@"MysticPoints", characterClass.MysticPoints),
							new XAttribute(@"RangerPoints", characterClass.RangerPoints),
							new XAttribute(@"WarriorPoints", characterClass.WarriorPoints)
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
		/// Handles the Click event of the add control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		/// <exception cref="Exception">A profile by the name {newName}</exception>
		private void add_Click(object sender, EventArgs e) {
			try {
				var newName = InputBox.ShowDialog(this, @"Select New Profile Name...", @"Class Profile Name", string.Empty);
				if (string.IsNullOrWhiteSpace(newName)) return;

				//Try using the new name as an XAttribute value.  
				new XAttribute("Sample", newName);

				var dataSourceAsProfileCollection = (this.selectedProfile.DataSource as BindingSource)?.DataSource as ClassProfileCollection;
				if (dataSourceAsProfileCollection != null) {
					if (this.ClassProfiles.Any(profile => profile.ClassProfileName.Equals(newName, StringComparison.OrdinalIgnoreCase))) {
						throw new Exception($"A profile by the name {newName} already exists.");
					}
					var newClass = dataSourceAsProfileCollection.Add(newName);
					this.BindClassProfiles();
					this.selectedProfile.SelectedItem = newClass;
				}
			}
			catch (Exception caught) {
				MessageBox.Show(this, $"Failure creating new class profile: {caught.Message}", @"Failure Creating Class Profile...", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// Handles the Click event of the aboutToolStripMenuItem control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
			using (var form = new About()) {
				form.ShowDialog(this);
			}
		}

		/// <summary>
		/// Handles the Validating event of the classLevel control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
		/// <exception cref="Exception">The value {senderAsTextBox.Text}</exception>
		private void classLevel_Validating(object sender, CancelEventArgs e) {
			var desiredProfile = this.selectedProfile.SelectedItem as ClassProfile;
			if (desiredProfile == null) return;

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
				var pointsUsed = ClassProfileUtility.CalculateClassPoints(classLevel);

				if (sender == warriorLevel) {
					desiredProfile.WarriorPoints = pointsUsed;
				}
				else if (sender == rangerLevel) {
					desiredProfile.RangerPoints = pointsUsed;
				}
				else if (sender == mysticLevel) {
					desiredProfile.MysticPoints = pointsUsed;
				}
				else if (sender == mageLevel) {
					desiredProfile.MagePoints = pointsUsed;
				}
				this.BindClassProfile(desiredProfile);
			}
			catch (Exception caught) {
				MessageBox.Show(
					this, 
					$"Failure validating input: {caught.Message}", 
					@"Failure Validating Input...", 
					MessageBoxButtons.OK, 
					MessageBoxIcon.Error
					);
				e.Cancel = true;
			}

		}

		/// <summary>
		/// Handles the Validating event of the classPoints control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
		/// <exception cref="Exception">The value {senderAsTextBox.Text}</exception>
		private void classPoints_Validating(object sender, CancelEventArgs e) {
			var classProfile = this.selectedProfile.SelectedItem as ClassProfile;
			if (classProfile == null) return;

			var senderAsTextBox = sender as TextBox;
			if (senderAsTextBox == null) return;

			if (string.IsNullOrWhiteSpace(senderAsTextBox.Text)) {
				senderAsTextBox.Text = "0";
			}

			try {
				var classPoints = 0;
				if (!int.TryParse(senderAsTextBox.Text, NumberStyles.Integer, CultureInfo.InvariantCulture, out classPoints)) {
					throw new Exception($"The value {senderAsTextBox.Text} is not a valid character points.");
				}

				if (senderAsTextBox == this.warriorPoints) {
					classProfile.WarriorPoints = classPoints;
				}
				else if (senderAsTextBox == this.rangerPoints) {
					classProfile.RangerPoints = classPoints;
				}
				else if (senderAsTextBox == this.mysticPoints) {
					classProfile.MysticPoints = classPoints;
				}
				else if (senderAsTextBox == this.magePoints) {
					classProfile.MagePoints = classPoints;
				}
				this.BindClassProfile(classProfile);
			}
			catch (Exception caught) {
				MessageBox.Show(
					this, 
					$"Failure validating input: {caught.Message}", 
					@"Failure Validating Input...", 
					MessageBoxButtons.OK, 
					MessageBoxIcon.Error
					);
				e.Cancel = true;
			}
		}

		/// <summary>
		/// Handles the Click event of the clear control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void clear_Click(object sender, EventArgs e) {
			var classProfile = this.selectedProfile.SelectedItem as ClassProfile;
			if (classProfile == null) return;
			
			classProfile.WarriorPoints = classProfile.RangerPoints = classProfile.MysticPoints = classProfile.MagePoints = 0;
			this.BindClassProfile(classProfile);
		}

		/// <summary>
		/// Handles the Click event of the close control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void close_Click(object sender, EventArgs e) {
			this.Close();
		}

		/// <summary>
		/// Handles the Click event of the copy control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void copy_Click(object sender, EventArgs e) {
			try {
				Clipboard.Clear();
				Clipboard.SetText($"{warriorPoints.Text};w;{rangerPoints.Text};r;{mysticPoints.Text};t;{magePoints.Text};m;=");
			}
			catch (ExternalException) { }
			catch (Exception caught) {
				MessageBox.Show(
					this,
					$"Failure copying to clipboard: {caught.Message}",
					@"Failure Copying Coefficient String...",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
					);
			}
		}

		/// <summary>
		/// Handles the Click event of the delete control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void delete_Click(object sender, EventArgs e) {
			var desiredProfile = this.selectedProfile.SelectedItem as ClassProfile;
			if (desiredProfile == null) return;

			if (this.ClassProfiles.Contains(desiredProfile)) {

				var response = MessageBox.Show(this, $"Are you SURE you want to delete the {desiredProfile.ClassProfileName} class profile?", @"Are you SURE?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (response != DialogResult.Yes) return;


				var selectedIndexMinusOne = this.selectedProfile.SelectedIndex - 1;
				this.ClassProfiles.Remove(desiredProfile);
				this.BindClassProfiles();
				this.selectedProfile.SelectedIndex = selectedIndexMinusOne <= -1 ? -1 : selectedIndexMinusOne;
			}

		}

		/// <summary>
		/// Handles the FormClosing event of the Main control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
		private void Main_FormClosing(object sender, FormClosingEventArgs e) {
			try {
				this.SaveConfiguration();
			}
			catch { }
		}

		/// <summary>
		/// Handles the CheckedChanged event of the raceRadio control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void raceRadio_CheckedChanged(object sender, EventArgs e) {
			this.CharacterRace = sender == whitieRadio
				? RaceType.Light
				: sender == urukHaiRadio
					? RaceType.Uruk
					: RaceType.Orc
					;

			this.BindClassProfile(this.selectedProfile.SelectedItem as ClassProfile);
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
				this.BindClassProfiles();
			}
			catch (Exception caught) {
				MessageBox.Show(
					this, 
					$"Failure re-generating classes: {caught.Message}", 
					@"Failure Re-Generating Classes...", 
					MessageBoxButtons.OK, 
					MessageBoxIcon.Error
					);
			}
		}

		/// <summary>
		/// Handles the Validating event of the selectedClass control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
		private void selectedClass_Validating(object sender, CancelEventArgs e) {
			try {
				this.BindClassProfile(this.selectedProfile.SelectedItem as ClassProfile);
			}
			catch (Exception caught) {
				MessageBox.Show(
					this,
					$"Failure validating profile: {caught.Message}",
					@"Failure Validating Profile...",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
					);
			}
		}

		/// <summary>
		/// Handles the SelectedIndexChanged event of the selectedProfile control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void selectedProfile_SelectedIndexChanged(object sender, EventArgs e) {
			try {
				this.BindClassProfile(this.selectedProfile.SelectedItem as ClassProfile);
			}
			catch (Exception caught) {
				MessageBox.Show(
					this,
					$"Failure selecting profile: {caught.Message}",
					@"Failure Selecting Profile...",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
					);
			}
		}

		#endregion

	}

}
