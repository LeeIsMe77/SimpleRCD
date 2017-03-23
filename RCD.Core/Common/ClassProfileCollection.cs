namespace RCD.Core.Common {

	#region Directives
	using System;
	using System.Collections.ObjectModel;
	using System.Linq;
	using System.Xml.Linq;
	using Extensions;
	#endregion

	public class ClassProfileCollection
		: ObservableCollection<ClassProfile> {

		#region Properties

		#region ConfigurationXml

		/// <summary>
		/// Gets the configuration XML.
		/// </summary>
		/// <value>The configuration XML.</value>
		public XElement ConfigurationXml =>	new XElement(
			@"ClassProfiles",
			this.Select(classProfile =>
				new XElement(@"ClassProfile",
					new XAttribute(@"ClassProfileName", classProfile.ClassProfileName),
					new XAttribute(@"MagePoints", classProfile.MagePoints),
					new XAttribute(@"MysticPoints", classProfile.MysticPoints),
					new XAttribute(@"RangerPoints", classProfile.RangerPoints),
					new XAttribute(@"WarriorPoints", classProfile.WarriorPoints)
					)
				)
			);

		#endregion

		#endregion

		#region Collection Management

		/// <summary>
		/// Adds the specified class name.
		/// </summary>
		/// <param name="className">Name of the class.</param>
		/// <returns>CharacterClass.</returns>
		public ClassProfile Add(string className) {
			var characterClass = new ClassProfile(className);
			this.Add(characterClass);
			return characterClass;
		}

		/// <summary>
		/// Adds the specified class name.
		/// </summary>
		/// <param name="className">Name of the class.</param>
		/// <param name="warriorPoints">The warrior points.</param>
		/// <param name="rangerPoints">The ranger points.</param>
		/// <param name="mysticPoints">The mystic points.</param>
		/// <param name="magePoints">The mage points.</param>
		/// <param name="isSystemClass">if set to <c>true</c> [is system class].</param>
		/// <returns>CharacterClass.</returns>
		public ClassProfile Add(string className, int warriorPoints, int rangerPoints, int mysticPoints, int magePoints) {
			var characterClass = new ClassProfile(className, warriorPoints, rangerPoints, mysticPoints, magePoints);
			this.Add(characterClass);
			return characterClass;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Loads the c onfiguration.
		/// </summary>
		/// <param name="configuration">The configuration.</param>
		public void LoadConfiguration(XElement configuration) {
			if (configuration == null) return;
			var classElements = configuration.Elements(@"ClassProfile");
			if (classElements != null) {
				foreach (var classElement in classElements) {

					var className = classElement.SafeAttributeValue<string>(@"ClassProfileName");
					if (string.IsNullOrWhiteSpace(className)) {
						throw new Exception(@"The class profile name cannot be blank.");
					}

					if (this.Any(characterClass => characterClass.ClassProfileName.Equals(className, StringComparison.OrdinalIgnoreCase))) {
						throw new Exception($"The class profile name {className} is a duplicate class.");
					}

					this.Add(
						className,
						classElement.SafeAttributeValue<int>(@"WarriorPoints"),
						classElement.SafeAttributeValue<int>(@"RangerPoints"),
						classElement.SafeAttributeValue<int>(@"MysticPoints"),
						classElement.SafeAttributeValue<int>(@"MagePoints")
					);
				}
			}
		}

		#endregion

	}

}
