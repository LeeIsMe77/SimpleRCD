namespace RCD.Core.Common {

	#region Directives
	using RCD.Core.Types;
	#endregion

	/// <summary>
	/// Class ClassSkill.
	/// </summary>
	public abstract class ClassSkill {

		#region Properties

		/// <summary>
		/// Gets the name of the skill.
		/// </summary>
		/// <value>The name of the skill.</value>
		public string SkillName { get; }

		/// <summary>
		/// Gets the Class
		/// </summary>
		/// <value>The class.</value>
		public ClassType Class { get; }

		/// <summary>
		/// Gets the skill level.
		/// </summary>
		/// <value>The skill level.</value>
		public int SkillLevel { get; }

		/// <summary>
		/// Gets the race.
		/// </summary>
		/// <value>The race.</value>
		public RaceType Race { get; }

		/// <summary>
		/// Gets the type of the specialization.
		/// </summary>
		/// <value>The type of the specialization.</value>
		public SpecializationType SpecializationType { get; }

		#endregion

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="ClassSkill" /> class.
		/// </summary>
		/// <param name="skillName">Name of the skill.</param>
		/// <param name="classType">Class of the skill.</param>
		/// <param name="skillLevel">The skill level.</param>
		/// <param name="race">The race.</param>
		public ClassSkill(string skillName, ClassType classType, int skillLevel, RaceType race, SpecializationType specializationType = SpecializationType.None) {
			this.SkillName = skillName;
			this.Class = classType;
			this.SkillLevel = skillLevel;
			this.Race = race;
			this.SpecializationType = specializationType;
		}

		#endregion

	}

	/// <summary>
	/// Class MageSpell. This class cannot be inherited.
	/// </summary>
	public sealed class MageSpell
		: ClassSkill {

		#region Properties

		/// <summary>
		/// Gets the minimum ticks.
		/// </summary>
		/// <value>The minimum ticks.</value>
		public int MinimumCastTime { get; }

		/// <summary>
		/// Gets the minimum cast time level.
		/// </summary>
		/// <value>The minimum cast time level.</value>
		public int MinimumCastTimeLevel { get; }

		/// <summary>
		/// Gets the minimum cost.
		/// </summary>
		/// <value>The minimum cost.</value>
		public int MinimumCost { get; }

		/// <summary>
		/// Gets the minimum cost level.
		/// </summary>
		/// <value>The minimum cost level.</value>
		public int MinimumCostLevel { get; }

		#endregion

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="MageSpell"/> class.
		/// </summary>
		/// <param name="skillName">Name of the skill.</param>
		/// <param name="skillLevel">The skill level.</param>
		/// <param name="race">The race.</param>
		/// <param name="minimumCastTime">The minimum ticks.</param>
		/// <param name="minimumCost">The minimum cost.</param>
		/// <param name="specializationType">Type of the specialization.</param>
		public MageSpell(string skillName, int skillLevel, RaceType race, int minimumCastTime, int minimumCastTimeLevel, int minimumCost, int minimumCostLevel, SpecializationType specializationType = SpecializationType.None)
			: base(skillName, ClassType.Mage, skillLevel, race, specializationType) {
			this.MinimumCost = minimumCost;
			this.MinimumCostLevel = minimumCostLevel;
			this.MinimumCastTime = minimumCastTime;
			this.MinimumCastTimeLevel = minimumCastTimeLevel;
		}

		#endregion

	}

	/// <summary>
	/// Class MysticPower. This class cannot be inherited.
	/// </summary>
	public sealed class MysticPower
		: ClassSkill {

		#region Properties

		/// <summary>
		/// Gets the minimum cast time.
		/// </summary>
		/// <value>The minimum cast time.</value>
		public int MinimumCastTime { get; }

		/// <summary>
		/// Gets the spirit cost.
		/// </summary>
		/// <value>The spirit cost.</value>
		public int SpiritCost { get; }

		#endregion

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="MysticPower"/> class.
		/// </summary>
		/// <param name="skillName">Name of the skill.</param>
		/// <param name="skillLevel">The skill level.</param>
		/// <param name="race">The race.</param>
		/// <param name="minimumCastTime">The minimum cast time.</param>
		/// <param name="spiritCost">The spirit cost.</param>
		/// <param name="specializationType">Type of the specialization.</param>
		public MysticPower(string skillName, int skillLevel, RaceType race, int minimumCastTime, int spiritCost, SpecializationType specializationType = SpecializationType.None) 
			: base(skillName, ClassType.Mystic, skillLevel, race, specializationType) {
			this.MinimumCastTime = minimumCastTime;
			this.SpiritCost = spiritCost;
		}

		#endregion

	}

	/// <summary>
	/// Class RangerSkill. This class cannot be inherited.
	/// </summary>
	public sealed class RangerSkill
		: ClassSkill {

		#region Properties

		/// <summary>
		/// Gets the minimum execution time.
		/// </summary>
		/// <value>The minimum execution time.</value>
		public int MinimumExecutionTime { get; }

		#endregion

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="RangerSkill" /> class.
		/// </summary>
		/// <param name="skillName">Name of the skill.</param>
		/// <param name="skillLevel">The skill level.</param>
		/// <param name="race">The race.</param>
		/// <param name="minimumExecuteTime">The minimum cast time.</param>
		/// <param name="spiritCost">The spirit cost.</param>
		/// <param name="specializationType">Type of the specialization.</param>
		public RangerSkill(string skillName, int skillLevel, RaceType race, int minimumExecuteTime, int spiritCost, SpecializationType specializationType = SpecializationType.None)
			: base(skillName, ClassType.Ranger, skillLevel, race, specializationType) {
			this.MinimumExecutionTime = minimumExecuteTime;
		}

		#endregion

	}

	/// <summary>
	/// Class WarriorSkill. This class cannot be inherited.
	/// </summary>
	public sealed class WarriorSkill
		: ClassSkill {

		#region Properties

		/// <summary>
		/// Gets the minimum execution time.
		/// </summary>
		/// <value>The minimum execution time.</value>
		public int MinimumExecutionTime { get; }

		#endregion

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="WarriorSkill" /> class.
		/// </summary>
		/// <param name="skillName">Name of the skill.</param>
		/// <param name="skillLevel">The skill level.</param>
		/// <param name="race">The race.</param>
		/// <param name="minimumExecuteTime">The minimum cast time.</param>
		/// <param name="spiritCost">The spirit cost.</param>
		/// <param name="specializationType">Type of the specialization.</param>
		public WarriorSkill(string skillName, int skillLevel, RaceType race, int minimumExecuteTime, int spiritCost, SpecializationType specializationType = SpecializationType.None)
			: base(skillName, ClassType.Warrior, skillLevel, race, specializationType) {
			this.MinimumExecutionTime = minimumExecuteTime;
		}

		#endregion

	}

}