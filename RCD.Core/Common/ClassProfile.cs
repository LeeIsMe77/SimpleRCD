using RCD.Core.Types;
namespace RCD.Core.Common {

	/// <summary>
	/// A class which represents a class profile for generation of new characters.
	/// </summary>
	public class ClassProfile {

		#region Properties

		#region CharacterClassName

		/// <summary>
		/// Gets or sets the name of the character class.
		/// </summary>
		/// <value>The name of the character class.</value>
		public string ClassProfileName { get; set; }

		#endregion
		
		#region MageLevel

		/// <summary>
		/// Gets or sets the mage level.
		/// </summary>
		/// <value>The mage level.</value>
		public int MagePoints { get; set; }

		#endregion

		#region MysticLevel

		/// <summary>
		/// Gets or sets the mystic level.
		/// </summary>
		/// <value>The mystic level.</value>
		public int MysticPoints { get; set; }

		#endregion

		#region RangerLevel

		/// <summary>
		/// Gets or sets the ranger level.
		/// </summary>
		/// <value>The ranger level.</value>
		public int RangerPoints { get; set; }

		#endregion

		#region WarriorLevel

		/// <summary>
		/// Gets or sets the warrior level.
		/// </summary>
		/// <value>The warrior level.</value>
		public int WarriorPoints { get; set; }

		#endregion

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="ClassProfile" /> class.
		/// </summary>
		public ClassProfile(string className) {
			this.ClassProfileName = className;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ClassProfile"/> class.
		/// </summary>
		/// <param name="magePoints">The mage coefficient.</param>
		/// <param name="mysticPoints">The mystic coefficient.</param>
		/// <param name="rangerPoints">The ranger coefficient.</param>
		/// <param name="warriorPoints">The warrior coefficient.</param>
		public ClassProfile(string className, int warriorPoints, int rangerPoints, int mysticPoints, int magePoints)
			: this(className) {
			this.MagePoints = magePoints;
			this.MysticPoints = mysticPoints;
			this.RangerPoints = rangerPoints;
			this.WarriorPoints = warriorPoints;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Calculates the points available.
		/// </summary>
		/// <returns>System.Int32.</returns>
		public int CalculatePointsAvailable() {
			return 150 - this.WarriorPoints - this.RangerPoints - this.MysticPoints - this.MagePoints;
		}
		
		#endregion

	}

}