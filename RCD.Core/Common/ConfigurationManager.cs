namespace RCD.Core.Common {

	#region Directives
	using System;
	using System.IO;
	using System.Xml.Linq;
	using Extensions;
	using Types;
	#endregion

	public class ConfigurationManager {

		#region Constants
		private const string CONFIGURATION_FILE_NAME = "SimpleRCD.xml";
		#endregion

		#region Properties

		#region ClassCollection

		private ClassProfileCollection _classProfiles;

		public ClassProfileCollection ClassProfiles => _classProfiles
			?? (_classProfiles = new ClassProfileCollection());

		#endregion

		#region ConfigurationFilePath

		private string _configurationFileDirectory = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData, Environment.SpecialFolderOption.Create)}\\RotS Class Designer";

		/// <summary>
		/// Gets the configuration file path.
		/// </summary>
		/// <value>The configuration file path.</value>
		private string ConfigurationFilePath {
			get { return Path.Combine(_configurationFileDirectory, CONFIGURATION_FILE_NAME); }
		}

		#endregion

		#region ConfigurationXml

		public XElement ConfigurationXml {
			get {
				var configurationXml = this.ClassProfiles.ConfigurationXml;
				configurationXml.Add(new XAttribute(@"CharacterRace", this.Race));
				return configurationXml;
			}
			set {
				if (value == null) return;
				this.Race = value.SafeAttributeValue<RaceType>(@"CharacterRace");
				this.ClassProfiles.LoadConfiguration(value);
			}
		}

		#endregion

		#region Race

		/// <summary>
		/// Gets or sets the race.
		/// </summary>
		/// <value>The race.</value>
		public RaceType Race { get; set; }

		#endregion

		#endregion

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="ConfigurationManager"/> class.
		/// </summary>
		public ConfigurationManager() {
			this.LoadConfiguration();
		}

		#endregion

		#region Methods

		#region Configuration

		/// <summary>
		/// Loads the configuration.
		/// </summary>
		private void LoadConfiguration() {
			this.ClassProfiles.Clear();
			if (!File.Exists(this.ConfigurationFilePath)) {
				this.ClassProfiles.Add(@"Warrior", 100, 25, 16, 9);
				this.ClassProfiles.Add(@"Ranger", 25, 100, 9, 16);
				this.ClassProfiles.Add(@"Mystic", 16, 9, 100, 25);
				this.ClassProfiles.Add(@"Mage", 9, 16, 25, 100);
				this.ClassProfiles.Add(@"Baiken", 59, 81, 1, 9);
				this.ClassProfiles.Add(@"Barbarian", 121, 25, 4, 0);
				this.ClassProfiles.Add(@"Healer", 4, 0, 121, 25);
				this.ClassProfiles.Add(@"Wizard", 4, 9, 16, 121);
				this.ClassProfiles.Add(@"Buffer", 100, 45, 4, 1);
				return;
			}
			this.ConfigurationXml = XElement.Load(this.ConfigurationFilePath);
		}

		/// <summary>
		/// Saves the configuration.
		/// </summary>
		public void SaveConfiguration() {
			if (!Directory.Exists(_configurationFileDirectory)) {
				Directory.CreateDirectory(_configurationFileDirectory);
			}
			this.ConfigurationXml.Save(this.ConfigurationFilePath);
		}

		/// <summary>
		/// Resets the configuration.
		/// </summary>
		public void ResetConfiguration() {
			if (File.Exists(this.ConfigurationFilePath)) {
				File.Delete(this.ConfigurationFilePath);
			}
			this.LoadConfiguration();
		}

		#endregion

		#endregion

	}

}
