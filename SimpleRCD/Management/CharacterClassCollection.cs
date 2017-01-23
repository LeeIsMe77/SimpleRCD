namespace SimpleRCD.Management {

	#region Directives
	using System.Collections.ObjectModel;
	#endregion

	public class CharacterClassCollection
		: Collection<CharacterClass> {

		#region Collection Management

		/// <summary>
		/// Adds the specified class name.
		/// </summary>
		/// <param name="className">Name of the class.</param>
		/// <returns>CharacterClass.</returns>
		public CharacterClass Add(string className) {
			var characterClass = new CharacterClass(className);
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
		public CharacterClass Add(string className, int warriorPoints, int rangerPoints, int mysticPoints, int magePoints, bool isSystemClass) {
			var characterClass = new CharacterClass(className, warriorPoints, rangerPoints, mysticPoints, magePoints, isSystemClass);
			this.Add(characterClass);
			return characterClass;
		}

		#endregion

	}

}
