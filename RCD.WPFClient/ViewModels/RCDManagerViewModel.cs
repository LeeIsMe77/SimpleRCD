namespace RCD.WPFClient.ViewModels {

	#region Directives
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Linq;
	using System.Windows;
	using System.Windows.Input;
	using System.Xml.Linq;
	using Core.Cache;
	using Core.Common;
	using Core.Types;
	using Core.Utility;
	using RCD.WPFClient.Helpers;
	#endregion

	public sealed class RCDManagerViewModel
		: ObservableObject {

		#region ConfigurationManager
		private readonly ConfigurationManager _configurationManager;
		#endregion

		#region Properties

		#region ClassProfiles

		/// <summary>
		/// Gets the class profiles.
		/// </summary>
		/// <value>The class profiles.</value>
		public ClassProfileCollection ClassProfiles {
			get { return _configurationManager.ClassProfiles; }			
		}

		#endregion

		#region  SelectedProfile

		private ClassProfile _selectedProfile;

		/// <summary>
		/// Gets or sets the selected profile.
		/// </summary>
		/// <value>The selected profile.</value>
		public ClassProfile SelectedProfile {
			get { return _selectedProfile ?? this.ClassProfiles.FirstOrDefault() ?? this.ClassProfiles.Add(@"New Profile", 0, 0, 0, 0); }
			set {
				if (_selectedProfile != value) {
					_selectedProfile = value;
					this.OnPropertyChanged(nameof(this.SelectedProfile));
					this.OnPropertyChanged(nameof(this.WarriorPoints));
					this.OnPropertyChanged(nameof(this.RangerPoints));
					this.OnPropertyChanged(nameof(this.MysticPoints));
					this.OnPropertyChanged(nameof(this.MagePoints));
					//this.SetPoints();
					this.BindLevel();
				}
			}
		}

		#endregion

		#region Race
		
		/// <summary>
		/// Gets or sets the race.
		/// </summary>
		/// <value>The race.</value>
		public RaceType Race {
			get { return _configurationManager.Race; }
			set {
				if (_configurationManager.Race != value) {
					_configurationManager.Race = value;
					this.OnPropertyChanged(nameof(this.Race));
					this.BindLevel();
				}
			}
		}

		#endregion

		#region WarriorPoints

		/// <summary>
		/// Gets or sets the warrior points.
		/// </summary>
		/// <value>The warrior points.</value>
		public int WarriorPoints {
			get { return this.SelectedProfile?.WarriorPoints ?? 0; }
			set {
				if (this.SelectedProfile == null) return;
				if (this.SelectedProfile.WarriorPoints != value) {
					this.SelectedProfile.WarriorPoints = value;
					this.OnPropertyChanged(nameof(this.WarriorPoints));
					this.BindLevel();
				}
			}
		}

		#endregion

		#region WarriorLevel

		private int _warriorLevel;

		/// <summary>
		/// Gets or sets the warrior level.
		/// </summary>
		/// <value>The warrior level.</value>
		public int WarriorLevel {
			get { return _warriorLevel; }
			set {
				if (_warriorLevel != value) {
					_warriorLevel = value;
					this.OnPropertyChanged(nameof(this.WarriorLevel));
					this.SetPoints();
					//this.BindLevel();
				}
			}
		}

		#endregion

		#region WarriorModifiedLevel

		private int _warriorModifiedLevel;

		/// <summary>
		/// Gets or sets the warrior modified level.
		/// </summary>
		/// <value>The warrior modified level.</value>
		public int WarriorModifiedLevel {
			get { return _warriorModifiedLevel; }
			set {
				if (_warriorModifiedLevel != value) {
					_warriorModifiedLevel = value;
					this.OnPropertyChanged(nameof(this.WarriorModifiedLevel));
				}
			}
		}

		#endregion

		#region RangerPoints

		/// <summary>
		/// Gets or sets the ranger points.
		/// </summary>
		/// <value>The ranger points.</value>
		public int RangerPoints {
			get { return this.SelectedProfile?.RangerPoints ?? 0; }
			set {
				if (this.SelectedProfile == null) return;
				if (this.SelectedProfile.RangerPoints != value) {
					this.SelectedProfile.RangerPoints = value;
					this.OnPropertyChanged(nameof(this.RangerPoints));
					this.BindLevel();
				}
			}
		}

		#endregion

		#region RangerLevel

		private int _rangerLevel;

		/// <summary>
		/// Gets or sets the ranger level.
		/// </summary>
		/// <value>The ranger level.</value>
		public int RangerLevel {
			get { return _rangerLevel; }
			set {
				if (_rangerLevel != value) {
					_rangerLevel = value;
					this.OnPropertyChanged(nameof(this.RangerLevel));
					this.SetPoints();
					//this.BindLevel();
				}
			}
		}

		#endregion

		#region RangerModifiedLevel

		private int _rangerModifiedLevel;

		/// <summary>
		/// Gets or sets the ranger modified level.
		/// </summary>
		/// <value>The ranger modified level.</value>
		public int RangerModifiedLevel {
			get { return _rangerModifiedLevel; }
			set {
				if (_rangerModifiedLevel != value) {
					_rangerModifiedLevel = value;
					this.OnPropertyChanged(nameof(this.RangerModifiedLevel));
				}
			}
		}

		#endregion

		#region MysticPoints

		/// <summary>
		/// Gets or sets the mystic points.
		/// </summary>
		/// <value>The mystic points.</value>
		public int MysticPoints {
			get { return this.SelectedProfile?.MysticPoints ?? 0; }
			set {
				if (this.SelectedProfile == null) return;
				if (this.SelectedProfile.MysticPoints != value) {
					this.SelectedProfile.MysticPoints = value;
					this.OnPropertyChanged(nameof(this.MysticPoints));
					this.BindLevel();
				}
			}
		}

		#endregion

		#region MysticLevel

		private int _mysticLevel;

		/// <summary>
		/// Gets or sets the mystic level.
		/// </summary>
		/// <value>The mystic level.</value>
		public int MysticLevel {
			get { return _mysticLevel; }
			set {
				if (_mysticLevel != value) {
					_mysticLevel = value;
					this.OnPropertyChanged(nameof(this.MysticLevel));
					this.SetPoints();
					//this.BindLevel();
				}
			}
		}

		#endregion

		#region MysticModifiedLevel

		private int _mysticModifiedLevel;

		/// <summary>
		/// Gets or sets the mystic modified level.
		/// </summary>
		/// <value>The mystic modified level.</value>
		public int MysticModifiedLevel {
			get { return _mysticModifiedLevel; }
			set {
				if (_mysticModifiedLevel != value) {
					_mysticModifiedLevel = value;
					this.OnPropertyChanged(nameof(this.MysticModifiedLevel));
				}
			}
		}

		#endregion

		#region MagePoints

		/// <summary>
		/// Gets or sets the mage points.
		/// </summary>
		/// <value>The mage points.</value>
		public int MagePoints {
			get { return this.SelectedProfile?.MagePoints ?? 0; }
			set {
				if (this.SelectedProfile == null) return;
				if (this.SelectedProfile.MagePoints != value) {
					this.SelectedProfile.MagePoints = value;
					this.OnPropertyChanged(nameof(this.MagePoints));
					this.BindLevel();
				}
			}
		}

		#endregion

		#region MageLevel

		private int _mageLevel;

		/// <summary>
		/// Gets or sets the mage level.
		/// </summary>
		/// <value>The mage level.</value>
		public int MageLevel {
			get { return _mageLevel; }
			set {
				if (_mageLevel != value) {
					_mageLevel = value;
					this.OnPropertyChanged(nameof(this.MageLevel));
					this.SetPoints();
					//this.BindLevel();
				}
			}
		}

		#endregion

		#region MageModifiedLevel

		private int _mageModifiedLevel;

		/// <summary>
		/// Gets or sets the mage modified level.
		/// </summary>
		/// <value>The mage modified level.</value>
		public int MageModifiedLevel {
			get { return _mageModifiedLevel; }
			set {
				if (_mageModifiedLevel != value) {
					_mageModifiedLevel = value;
					this.OnPropertyChanged(nameof(this.MageModifiedLevel));
				}
			}
		}

		#endregion

		#region PointsRemaining

		private int _pointsRemaining = 150;

		/// <summary>
		/// Gets or sets the points remaining.
		/// </summary>
		/// <value>The points remaining.</value>
		public int PointsRemaining {
			get { return _pointsRemaining; }
			set {
				if (_pointsRemaining != value) {
					_pointsRemaining = value;
					this.OnPropertyChanged(nameof(this.PointsRemaining));
				}
			}
		}

		#endregion

		#region Commands

		#region AddClassCommand

		private ICommand _addClassCommand;

		/// <summary>
		/// Gets the add class command.
		/// </summary>
		/// <value>The add class command.</value>
		public ICommand AddClassCommand => _addClassCommand 
			?? (_addClassCommand = new RelayCommand(this.AddProfile));

		#endregion

		#region DeleteClassCommand

		private ICommand _deleteClassCommand;

		/// <summary>
		/// Gets the delete class command.
		/// </summary>
		/// <value>The delete class command.</value>
		public ICommand DeleteClassCommand => _deleteClassCommand
			?? (_deleteClassCommand = new RelayCommand(this.DeleteProfile));

		#endregion

		#region SaveConfigurationCommand

		private ICommand _saveConfigurationCommand;

		/// <summary>
		/// Gets the save configuration command.
		/// </summary>
		/// <value>The save configuration command.</value>
		public ICommand SaveConfigurationCommand => _saveConfigurationCommand
			?? (_saveConfigurationCommand = new RelayCommand(this.SaveConfiguration));

		#endregion

		//SaveConfigurationCommand
		#endregion

		#region Skill Lists

		#region WarriorSkills

		private ClassSkillCollection _warriorSkills;

		/// <summary>
		/// Gets or sets the available skills.
		/// </summary>
		/// <value>The available skills.</value>
		public ClassSkillCollection WarriorSkills {
			get {
				if (_warriorSkills == null) {
					_warriorSkills = new ClassSkillCollection();
					_warriorSkills.AddRange(RCDCache.Skills.OfType<WarriorSkill>());
				}
				return _warriorSkills;
			}
		}

		#endregion

		#region RangerSkills

		private ClassSkillCollection _rangerSkills;

		/// <summary>
		/// Gets or sets the available skills.
		/// </summary>
		/// <value>The available skills.</value>
		public ClassSkillCollection RangerSkills {
			get {
				if (_rangerSkills == null) {
					_rangerSkills = new ClassSkillCollection();
					_rangerSkills.AddRange(RCDCache.Skills.OfType<RangerSkill>());
				}
				return _rangerSkills;
			}
		}

		#endregion

		#region MysticSkills

		private ClassSkillCollection _mysticSkills;

		/// <summary>
		/// Gets or sets the available skills.
		/// </summary>
		/// <value>The available skills.</value>
		public ClassSkillCollection MysticSkills {
			get {
				if (_mysticSkills == null) {
					_mysticSkills = new ClassSkillCollection();
					_mysticSkills.AddRange(RCDCache.Skills.OfType<MysticPower>());
				}
				return _mysticSkills;
			}
		}

		#endregion

		#region MageSkills

		private ClassSkillCollection _mageSkills;

		/// <summary>
		/// Gets or sets the available skills.
		/// </summary>
		/// <value>The available skills.</value>
		public ClassSkillCollection MageSkills {
			get {
				if (_mageSkills == null) {
					_mageSkills = new ClassSkillCollection();
					_mageSkills.AddRange(RCDCache.Skills.OfType<MageSpell>());
				}
				return _mageSkills;
			}
		}

		#endregion

		#endregion

		#endregion

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="RCDManagerViewModel"/> class.
		/// </summary>
		/// <param name="configurationManager">The configuration manager.</param>
		public RCDManagerViewModel(ConfigurationManager configurationManager) {
			_configurationManager = configurationManager;
			this.BindLevel();
		}

		#endregion

		#region Methods

		#region Character Profile Management

		/// <summary>
		/// Sets the class points for the current levels.
		/// </summary>
		private void SetPoints() {

			var defaultModifier = _configurationManager.Race == RaceType.OrcHai ? 2m / 3m : 1.0m;

			#region Warrior Row
			this.SelectedProfile.WarriorPoints = ClassProfileUtility.CalculateClassPoints(this.WarriorLevel);
			this.OnPropertyChanged(nameof(this.WarriorPoints));

			var rawWarriorLevel = ClassProfileUtility.CalculateClassLevel(this.WarriorPoints);
			var modifiedWarriorLevel = ((int)Math.Floor((decimal)rawWarriorLevel * defaultModifier));
			this.WarriorModifiedLevel = modifiedWarriorLevel;
			#endregion

			#region Ranger Row
			this.SelectedProfile.RangerPoints = ClassProfileUtility.CalculateClassPoints(this.RangerLevel);
			this.OnPropertyChanged(nameof(this.RangerPoints));

			var rawRangerLevel = ClassProfileUtility.CalculateClassLevel(this.RangerPoints);
			var modifiedRangerLevel = ((int)Math.Floor((decimal)rawRangerLevel * defaultModifier));
			this.RangerModifiedLevel = modifiedRangerLevel;
			#endregion

			#region Mystic Row
			this.SelectedProfile.MysticPoints = ClassProfileUtility.CalculateClassPoints(this.MysticLevel);
			this.OnPropertyChanged(nameof(this.MysticPoints));

			var rawMysticLevel = ClassProfileUtility.CalculateClassLevel(this.MysticPoints);
			var modifiedMysticLevel = ((int)Math.Floor((decimal)rawMysticLevel * defaultModifier));
			this.MysticModifiedLevel = modifiedMysticLevel;
			#endregion

			#region Mage Row
			this.SelectedProfile.MagePoints = ClassProfileUtility.CalculateClassPoints(this.MageLevel);
			this.OnPropertyChanged(nameof(this.MagePoints));

			var rawMageLevel = ClassProfileUtility.CalculateClassLevel(this.MagePoints);
			var modifiedMageLevel = (int)Math.Floor(_configurationManager.Race == RaceType.UrukHai ? (decimal)rawMageLevel - 3 : (decimal)rawMageLevel * defaultModifier);
			this.MageModifiedLevel = (modifiedMageLevel < 0 ? 0 : modifiedMageLevel);
			#endregion

			this.PointsRemaining = this.SelectedProfile.CalculatePointsAvailable();

		}
		
		/// <summary>
		/// Sets the class levels for the current points.
		/// </summary>
		/// <param name="classProfile">The class profile.</param>
		private void BindLevel() {
			
			var defaultModifier = _configurationManager.Race == RaceType.OrcHai ? 2m / 3m : 1.0m;

			#region Warrior Row
			var warriorLevel = ClassProfileUtility.CalculateClassLevel(this.WarriorPoints);
			_warriorLevel = ((int)Math.Floor(warriorLevel));
			this.OnPropertyChanged(nameof(this.WarriorLevel));

			var modifiedWarriorLevel = ((int)Math.Floor((decimal)warriorLevel * defaultModifier));
			this.WarriorModifiedLevel = modifiedWarriorLevel;
			#endregion

			#region Ranger Row
			var rangerLevel = ClassProfileUtility.CalculateClassLevel(this.RangerPoints);
			_rangerLevel = ((int)Math.Floor(rangerLevel));
			this.OnPropertyChanged(nameof(this.RangerLevel));

			var modifiedRangerLevel = ((int)Math.Floor((decimal)rangerLevel * defaultModifier));
			this.RangerModifiedLevel = modifiedRangerLevel;
			#endregion

			#region Mystic Row
			var mysticLevel = ClassProfileUtility.CalculateClassLevel(this.MysticPoints);
			_mysticLevel = ((int)Math.Floor(mysticLevel));
			this.OnPropertyChanged(nameof(this.MysticLevel));

			var modifiedMysticLevel = ((int)Math.Floor((decimal)mysticLevel * defaultModifier));
			this.MysticModifiedLevel = modifiedMysticLevel;
			#endregion

			#region Mage Row
			var mageLevel = ClassProfileUtility.CalculateClassLevel(this.MagePoints);
			_mageLevel = ((int)Math.Floor(mageLevel));
			this.OnPropertyChanged(nameof(this.MageLevel));

			var modifiedMageLevel = (int)Math.Floor(_configurationManager.Race == RaceType.UrukHai ? (decimal)mageLevel - 3 : (decimal)mageLevel * defaultModifier);
			this.MageModifiedLevel = (modifiedMageLevel < 0 ? 0 : modifiedMageLevel);
			#endregion

			this.PointsRemaining = this.SelectedProfile.CalculatePointsAvailable();
		}
		
		#endregion

		/// <summary>
		/// Adds the profile.
		/// </summary>
		/// <exception cref="Exception">A profile by the name {newName}</exception>
		private void AddProfile(object sender) {
			try {
				var newName = InputBox.ShowDialog(@"Select New Profile Name...", @"Class Profile Name:", string.Empty);
				if (string.IsNullOrWhiteSpace(newName)) return;

				//Try using the new name as an XAttribute value.  
				new XAttribute("Sample", newName);

				if (_configurationManager.ClassProfiles.Any(profile => profile.ClassProfileName.Equals(newName, StringComparison.OrdinalIgnoreCase))) {
					throw new Exception($"A profile by the name {newName} already exists.");
				}
				var newClass = _configurationManager.ClassProfiles.Add(newName);
				//this.BindClassProfiles();
				this.SelectedProfile = newClass;
			}
			catch (Exception caught) {
				MessageBox.Show(
					$"Failure creating class profile: {caught.Message}",
					@"Failure Creating Class Profile...",
					MessageBoxButton.OK,
					MessageBoxImage.Error
					);
			}
		}

		/// <summary>
		/// Deletes the profile.
		/// </summary>
		/// <param name="sender">The sender.</param>
		private void DeleteProfile(object sender) {
			try {
				if (this.SelectedProfile != null && this.ClassProfiles.Contains(this.SelectedProfile)) {
					var indexOfProfile = this.ClassProfiles.IndexOf(this.SelectedProfile);
					this.ClassProfiles.Remove(this.SelectedProfile);
					this.OnPropertyChanged(nameof(this.ClassProfiles));

					if (this.ClassProfiles.Count == 0) return;
					if (indexOfProfile + 1 > this.ClassProfiles.Count) {
						this.SelectedProfile = this.ClassProfiles.Last();
						return;
					}
					this.SelectedProfile = this.ClassProfiles[indexOfProfile];
				}

			}
			catch (Exception caught) {
				MessageBox.Show(
					$"Failure deleting class profile: {caught.Message}",
					@"Failure Deleting Class Profile...",
					MessageBoxButton.OK,
					MessageBoxImage.Error
					);
			}
		}

		/// <summary>
		/// Saves the configuration.
		/// </summary>
		/// <param name="sender">The sender.</param>
		private void SaveConfiguration(object sender) {
			try {
				_configurationManager.SaveConfiguration();
			}
			catch { }
		}

		#endregion

		#region Control Events

		/// <summary>
		/// Handles the Closing event of the window control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
		/// <exception cref="NotImplementedException"></exception>
		internal void window_Closing(object sender, CancelEventArgs e) {
			this.SaveConfiguration(sender);
		}

		#endregion

	}

}
