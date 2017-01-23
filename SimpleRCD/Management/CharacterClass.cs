namespace SimpleRCD.Management {

	#region Directives
	#endregion

	/// <summary>
	/// A class which represents a character.
	/// </summary>
	public class CharacterClass {

		#region Properties

		#region CharacterClassName

		/// <summary>
		/// Gets or sets the name of the character class.
		/// </summary>
		/// <value>The name of the character class.</value>
		public string CharacterClassName { get; set; }

		#endregion

		#region IsSystemClass

		/// <summary>
		/// Gets a value indicating whether this instance is system class.
		/// </summary>
		/// <value><c>true</c> if this instance is system class; otherwise, <c>false</c>.</value>
		public bool IsSystemClass { get; }

		#endregion

		#region MageLevel

		/// <summary>
		/// Gets or sets the mage level.
		/// </summary>
		/// <value>The mage level.</value>
		public int MageLevel { get; set; }

		#endregion

		#region MysticLevel

		/// <summary>
		/// Gets or sets the mystic level.
		/// </summary>
		/// <value>The mystic level.</value>
		public int MysticLevel { get; set; }

		#endregion

		#region RangerLevel

		/// <summary>
		/// Gets or sets the ranger level.
		/// </summary>
		/// <value>The ranger level.</value>
		public int RangerLevel { get; set; }

		#endregion

		#region WarriorLevel

		/// <summary>
		/// Gets or sets the warrior level.
		/// </summary>
		/// <value>The warrior level.</value>
		public int WarriorLevel { get; set; }

		#endregion

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="CharacterClass" /> class.
		/// </summary>
		public CharacterClass(string className) {
			this.CharacterClassName = className;
			this.IsSystemClass = false;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="CharacterClass"/> class.
		/// </summary>
		/// <param name="magePoints">The mage coefficient.</param>
		/// <param name="mysticPoints">The mystic coefficient.</param>
		/// <param name="rangerPoints">The ranger coefficient.</param>
		/// <param name="warriorPoints">The warrior coefficient.</param>
		public CharacterClass(string className, int warriorPoints, int rangerPoints, int mysticPoints, int magePoints, bool isSystemClass)
			: this(className) {
			this.MageLevel = magePoints;
			this.MysticLevel = mysticPoints;
			this.RangerLevel = rangerPoints;
			this.WarriorLevel = warriorPoints;
			this.IsSystemClass = isSystemClass;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Calculates the points available.
		/// </summary>
		/// <returns>System.Int32.</returns>
		public int CalculatePointsAvailable() {
			return 150 - this.CalculatePointsUsed();
		}

		/// <summary>
		/// Calculates the points used.
		/// </summary>
		/// <returns>System.Int32.</returns>
		public int CalculatePointsUsed() {
			return CharacterClassUtility.CalculatePointsUsed(this.WarriorLevel) +
				CharacterClassUtility.CalculatePointsUsed(this.RangerLevel) +
				CharacterClassUtility.CalculatePointsUsed(this.MysticLevel) +
				CharacterClassUtility.CalculatePointsUsed(this.MageLevel);
		}

		#endregion

	}

}