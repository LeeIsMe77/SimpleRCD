namespace RCD.WPFClient.ViewModels {

	#region Directives
	using System;
	using System.Collections.Generic;
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

		#region Profiles

		/// <summary>
		/// Gets the profiles.
		/// </summary>
		/// <value>The profiles.</value>
		public ClassProfileCollection Profiles {
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
			get { return _selectedProfile ?? this.Profiles.FirstOrDefault() ?? this.Profiles.Add(@"New Profile", 0, 0, 0, 0); }
			set {
				if (_selectedProfile != value) {
					_selectedProfile = value;
					this.OnPropertyChanged(nameof(this.SelectedProfile));
					this.OnPropertyChanged(nameof(this.WarriorPoints));
					this.OnPropertyChanged(nameof(this.RangerPoints));
					this.OnPropertyChanged(nameof(this.MysticPoints));
					this.OnPropertyChanged(nameof(this.MagePoints));
					this.BindClassProfile(this.SelectedProfile);
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

		#region MageModifiedLevel

		private int _mageModifiedLevel;

		/// <summary>
		/// Gets or sets the mage modified level.
		/// </summary>
		/// <value>The mage modified level.</value>
		public int MageModifiedLevel {
			get { return _mageLevel; }
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

		#endregion

		#region AvailableSkills

		private ClassSkillCollection _availableSkills;

		/// <summary>
		/// Gets or sets the available skills.
		/// </summary>
		/// <value>The available skills.</value>
		public ClassSkillCollection AvailableSkills {
			get { return _availableSkills ?? (_availableSkills = new ClassSkillCollection()); }
			set {
				if (_availableSkills != value) {
					_availableSkills = value;
					this.OnPropertyChanged(nameof(this.AvailableSkills));
				}
			}
		}

		#endregion

		#endregion

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="RCDManagerViewModel"/> class.
		/// </summary>
		/// <param name="configurationManager">The configuration manager.</param>
		public RCDManagerViewModel(ConfigurationManager configurationManager) {
			_configurationManager = configurationManager;
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
				this.AvailableSkills.Clear();
				//var applicableSkills = RCDCache.Skills
				//	.Where(skill => (skill.Race & _configurationManager.Race) == _configurationManager.Race)
				//	.Where(skill =>
				//		(skill.Class == ClassType.Mage && skill.SkillLevel <= MageModifiedLevel) ||
				//		(skill.Class == ClassType.Warrior && skill.SkillLevel <= this.WarriorModifiedLevel) ||
				//		(skill.Class == ClassType.Mystic && skill.SkillLevel <= MysticModifiedLevel) ||
				//		(skill.Class == ClassType.Ranger && skill.SkillLevel <= RangerModifiedLevel)
				//	)
				//	.OrderBy(skill => skill.Class)
				//	.ThenBy(skill => skill.SkillLevel)
				//	;
				var skills = new ClassSkillCollection();

				skills.AddRange(
					RCDCache.Skills
					.Where(skill => (skill.Race & _configurationManager.Race) == _configurationManager.Race)
					.Where(skill =>
						(skill.Class == ClassType.Mage && skill.SkillLevel <= MageModifiedLevel) ||
						(skill.Class == ClassType.Warrior && skill.SkillLevel <= this.WarriorModifiedLevel) ||
						(skill.Class == ClassType.Mystic && skill.SkillLevel <= MysticModifiedLevel) ||
						(skill.Class == ClassType.Ranger && skill.SkillLevel <= RangerModifiedLevel)
					)
					.OrderBy(skill => skill.Class)
					.ThenBy(skill => skill.SkillLevel)
					);

				this.AvailableSkills = skills;
			}
			catch (Exception caught) {
				MessageBox.Show(
					$"Failure binding skills: {caught.Message}",
					@"Failure Binding Skills...",
					MessageBoxButton.OK,
					MessageBoxImage.Error					
					);
			}
		}
		
		/// <summary>
		/// Binds the class profile.
		/// </summary>
		/// <param name="classProfile">The class profile.</param>
		private void BindClassProfile(ClassProfile classProfile) {
			#region Set readonly and enabled properties in applicable controls
			//this.warriorLevel.ReadOnly
			//	= this.rangerLevel.ReadOnly
			//	= this.mageLevel.ReadOnly
			//	= this.mysticLevel.ReadOnly
			//	= (classProfile == null || _configurationManager.Race == RaceType.Orc);

			//this.warriorLevel.Enabled
			//	= this.rangerLevel.Enabled
			//	= this.mageLevel.Enabled
			//	= this.mysticLevel.Enabled
			//	= (classProfile != null && _configurationManager.Race != RaceType.Orc);

			//this.warriorPoints.ReadOnly
			//	= this.rangerPoints.ReadOnly
			//	= this.magePoints.ReadOnly
			//	= this.mysticPoints.ReadOnly
			//	= classProfile == null;

			//this.warriorPoints.Enabled
			//	= this.rangerPoints.Enabled
			//	= this.magePoints.Enabled
			//	= this.mysticPoints.Enabled
			//	= classProfile != null;

			//this.clear.Enabled
			//	= this.delete.Enabled
			//	= classProfile != null;
			#endregion

			if (classProfile == null) {
				//If no profile has been passed, set a default Empty profile.
				classProfile = new ClassProfile("Empty", 0, 0, 0, 0);
			}

			var defaultModifier = _configurationManager.Race == RaceType.Orc ? 2m / 3m : 1.0m;

			#region Warrior Row
			var warriorLevel = ClassProfileUtility.CalculateClassLevel(classProfile.WarriorPoints);
			this.WarriorLevel = ((int)Math.Floor(warriorLevel));
			this.WarriorPoints = classProfile.WarriorPoints;
			var modifiedWarriorLevel = ((int)Math.Floor((decimal)warriorLevel * defaultModifier));
			this.WarriorModifiedLevel = modifiedWarriorLevel;
			#endregion

			#region Ranger Row
			var rangerLevel = ClassProfileUtility.CalculateClassLevel(classProfile.RangerPoints);
			this.RangerLevel = ((int)Math.Floor(rangerLevel));
			this.RangerPoints = classProfile.RangerPoints;
			var modifiedRangerLevel = ((int)Math.Floor((decimal)rangerLevel * defaultModifier));
			this.RangerModifiedLevel = modifiedRangerLevel;
			#endregion

			#region Mystic Row
			var mysticLevel = ClassProfileUtility.CalculateClassLevel(classProfile.MysticPoints);
			this.MysticLevel = ((int)Math.Floor(mysticLevel));
			this.MysticPoints = classProfile.MysticPoints;
			var modifiedMysticLevel = ((int)Math.Floor((decimal)mysticLevel * defaultModifier));
			this.MysticModifiedLevel = modifiedMysticLevel;
			#endregion

			#region Mage Row
			var mageLevel = ClassProfileUtility.CalculateClassLevel(classProfile.MagePoints);
			this.MageLevel = ((int)Math.Floor(mageLevel));
			this.MagePoints = classProfile.MagePoints;
			var modifiedMageLevel = (int)Math.Floor(_configurationManager.Race == RaceType.Uruk ? (decimal)mageLevel - 3 : (decimal)mageLevel * defaultModifier);
			this.MageModifiedLevel = (modifiedMageLevel < 0 ? 0 : modifiedMageLevel);
			#endregion

			this.PointsRemaining = classProfile.CalculatePointsAvailable();
			this.BindSkillGrid(classProfile);
		}
		
		#endregion

		/// <summary>
		/// Adds the profile.
		/// </summary>
		/// <exception cref="Exception">A profile by the name {newName}</exception>
		private void AddProfile(object sender) {
			try {
				var newName = RCD.WPFClient.InputBox.ShowDialog(/*Application.Current.MainWindow, */@"Select New Profile Name...", @"Class Profile Name:", string.Empty);
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

		#endregion

	}

}
