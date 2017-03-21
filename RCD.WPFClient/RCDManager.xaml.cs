namespace RCD.WPFClient {

	#region Directives
	using System;
	using System.IO;
	using System.Linq;
	using System.Windows;
	using System.Windows.Input;
	using System.Windows.Interop;
	using System.Windows.Media.Imaging;
	using System.Xml.Linq;
	using Core.Common;
	using Core.Types;
	using Extensions;
	#endregion

	/// <summary>
	/// Interaction logic for RCDManager.xaml
	/// </summary>
	public partial class RCDManager
		: Window {

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

		public RCDManager() {
			InitializeComponent();
			this.Icon = Imaging.CreateBitmapSourceFromHIcon(
				RCD.WPFClient.Properties.Resources.AssemblyIcon.Handle,
				Int32Rect.Empty,
				BitmapSizeOptions.FromEmptyOptions()
				);
			this.CharacterRace = RaceType.Light;
			this.lightButton.IsChecked = true;		
		}


		#region Methods

		//#region Character Profile Management

		///// <summary>
		///// Binds the skill grid.
		///// </summary>
		///// <param name="classProfile">The class profile.</param>
		//private void BindSkillGrid(ClassProfile classProfile) {
		//	try {
		//		this.skillsGridView.DataSource = null;

		//		var warriorLevel = string.IsNullOrWhiteSpace(modifiedWarrior.Text) ? 0 : int.Parse(modifiedWarrior.Text);
		//		var rangerLevel = string.IsNullOrWhiteSpace(modifiedRanger.Text) ? 0 : int.Parse(modifiedRanger.Text);
		//		var mysticLevel = string.IsNullOrWhiteSpace(modifiedMystic.Text) ? 0 : int.Parse(modifiedMystic.Text);
		//		var mageLevel = string.IsNullOrWhiteSpace(modifiedMage.Text) ? 0 : int.Parse(modifiedMage.Text);

		//		var applicableSkills = RCDCache.Skills
		//			.Where(skill => (skill.Race & this.CharacterRace) == this.CharacterRace)
		//			.Where(skill =>
		//				(skill.Class == ClassType.Mage && skill.SkillLevel <= mageLevel) ||
		//				(skill.Class == ClassType.Warrior && skill.SkillLevel <= warriorLevel) ||
		//				(skill.Class == ClassType.Mystic && skill.SkillLevel <= mysticLevel) ||
		//				(skill.Class == ClassType.Ranger && skill.SkillLevel <= rangerLevel)
		//			)
		//			.OrderBy(skill => skill.Class)
		//			.ThenBy(skill => skill.SkillLevel)
		//			;

		//		this.skillsGridView.DataSource = applicableSkills.ToList();
		//	}
		//	catch (Exception caught) {
		//		MessageBox.Show(
		//			this,
		//			$"Failure binding skills: {caught.Message}",
		//			@"Failure Binding Skills...",
		//			MessageBoxButtons.OK,
		//			MessageBoxIcon.Error
		//			);
		//	}
		//}

		///// <summary>
		///// Binds the class profiles.
		///// </summary>
		//private void BindClassProfiles() {
		//	this.selectedProfile.DataSource = null;
		//	var bindingSource = new BindingSource(this.ClassProfiles, null);
		//	this.selectedProfile.DataSource = bindingSource;
		//	this.selectedProfile.DisplayMember = @"ClassProfileName";
		//}

		///// <summary>
		///// Binds the class profile.
		///// </summary>
		///// <param name="classProfile">The class profile.</param>
		//private void BindClassProfile(ClassProfile classProfile) {
		//	//var currentProfile = this.selectedProfile.SelectedItem as ClassProfile;
		//	#region Set readonly and enabled properties in applicable controls
		//	this.warriorLevel.ReadOnly
		//		= this.rangerLevel.ReadOnly
		//		= this.mageLevel.ReadOnly
		//		= this.mysticLevel.ReadOnly
		//		= (classProfile == null || this.CharacterRace == RaceType.Orc);

		//	this.warriorLevel.Enabled
		//		= this.rangerLevel.Enabled
		//		= this.mageLevel.Enabled
		//		= this.mysticLevel.Enabled
		//		= (classProfile != null && this.CharacterRace != RaceType.Orc);

		//	this.warriorPoints.ReadOnly
		//		= this.rangerPoints.ReadOnly
		//		= this.magePoints.ReadOnly
		//		= this.mysticPoints.ReadOnly
		//		= classProfile == null;

		//	this.warriorPoints.Enabled
		//		= this.rangerPoints.Enabled
		//		= this.magePoints.Enabled
		//		= this.mysticPoints.Enabled
		//		= classProfile != null;

		//	this.clear.Enabled
		//		= this.delete.Enabled
		//		= classProfile != null;
		//	#endregion

		//	if (classProfile == null) {
		//		//If no profile has been passed, set a default Empty profile.
		//		classProfile = new ClassProfile("Empty", 0, 0, 0, 0);
		//	}

		//	var defaultModifier = this.CharacterRace == RaceType.Orc ? 2m / 3m : 1.0m;

		//	#region Warrior Row
		//	var warriorLevel = ClassProfileUtility.CalculateClassLevel(classProfile.WarriorPoints);
		//	this.warriorLevel.Text = ((int)Math.Floor(warriorLevel)).ToString();
		//	this.warriorPoints.Text = classProfile.WarriorPoints.ToString();
		//	var modifiedWarriorLevel = ((int)Math.Floor((decimal)warriorLevel * defaultModifier));
		//	this.modifiedWarrior.Text = modifiedWarriorLevel.ToString();
		//	#endregion

		//	#region Ranger Row
		//	var rangerLevel = ClassProfileUtility.CalculateClassLevel(classProfile.RangerPoints);
		//	this.rangerLevel.Text = ((int)Math.Floor(rangerLevel)).ToString();
		//	this.rangerPoints.Text = classProfile.RangerPoints.ToString();
		//	var modifiedRangerLevel = ((int)Math.Floor((decimal)rangerLevel * defaultModifier));
		//	this.modifiedRanger.Text = modifiedRangerLevel.ToString();
		//	#endregion

		//	#region Mystic Row
		//	var mysticLevel = ClassProfileUtility.CalculateClassLevel(classProfile.MysticPoints);
		//	this.mysticLevel.Text = ((int)Math.Floor(mysticLevel)).ToString();
		//	this.mysticPoints.Text = classProfile.MysticPoints.ToString();
		//	var modifiedMysticLevel = ((int)Math.Floor((decimal)mysticLevel * defaultModifier));
		//	this.modifiedMystic.Text = modifiedMysticLevel.ToString();
		//	#endregion

		//	#region Mage Row
		//	var mageLevel = ClassProfileUtility.CalculateClassLevel(classProfile.MagePoints);
		//	this.mageLevel.Text = ((int)Math.Floor(mageLevel)).ToString();
		//	this.magePoints.Text = classProfile.MagePoints.ToString();
		//	var modifiedMageLevel = (int)Math.Floor(this.CharacterRace == RaceType.Uruk ? (decimal)mageLevel - 3 : (decimal)mageLevel * defaultModifier);
		//	this.modifiedMage.Text = (modifiedMageLevel < 0 ? 0 : modifiedMageLevel).ToString();
		//	#endregion

		//	this.DisplayPointsRemaining(classProfile.CalculatePointsAvailable());
		//	this.BindSkillGrid(classProfile);
		//}

		///// <summary>
		///// Displays the points remaining.
		///// </summary>
		///// <param name="pointsRemaining">The points remaining.</param>
		//private void DisplayPointsRemaining(int pointsRemaining) {
		//	this.pointsRemaining.ForeColor = pointsRemaining < 0
		//		? Color.Red
		//		: Color.Green
		//		;

		//	this.pointsRemaining.Text = pointsRemaining.ToString();
		//}

		//#endregion

		#region Configuration

		/// <summary>
		/// Loads the configuration.
		/// </summary>
		private void LoadConfiguration() {
			var classCollection = new ClassProfileCollection();

			if (!File.Exists(this.ConfigurationFilePath)) {
				classCollection.Add(@"Warrior", 100, 25, 16, 9);
				classCollection.Add(@"Ranger", 25, 100, 9, 16);
				classCollection.Add(@"Mystic", 16, 9, 100, 25);
				classCollection.Add(@"Mage", 9, 16, 25, 100);
				classCollection.Add(@"Baiken", 59, 81, 1, 9);
				classCollection.Add(@"Barbarian", 121, 25, 4, 0);
				classCollection.Add(@"Healer", 4, 0, 121, 25);
				classCollection.Add(@"Wizard", 4, 9, 16, 121);
				classCollection.Add(@"Buffer", 100, 45, 4, 1);
			}
			else {
				var configurationFile = XElement.Load(this.ConfigurationFilePath);

				this.CharacterRace = configurationFile.SafeAttributeValue<RaceType>(@"CharacterRace");
				(this.CharacterRace == RaceType.Light ? this.lightButton : this.CharacterRace == RaceType.Uruk ? this.darkButton : this.orcButton).IsChecked = true;

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

		#endregion

		#endregion

		#region Control Events

		/// <summary>
		/// Handles the Click event of the close control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
		private void close_Click(object sender, RoutedEventArgs e) {
			this.Close();
		}

		private void raceButton_Checked(object sender, RoutedEventArgs e) {

		}
		
		private void add_Click(object sender, RoutedEventArgs e) {

		}

		private void delete_Click(object sender, RoutedEventArgs e) {

		}

		private void Window_Loaded(object sender, RoutedEventArgs e) {
			try {
				this.LoadConfiguration();
				//this.BindClassProfiles();
			}
			catch (Exception caught) {
				MessageBox.Show(
					$"Failure loading application: {caught.Message}",
					@"Failre Loading Application...",
					MessageBoxButton.OK,
					MessageBoxImage.Error
					);
			}
		}

		private void numericTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e) {
			if (!char.IsDigit(e.Text, e.Text.Length - 1)) {
				e.Handled = true;
			}
		}

		#endregion

	}

}
