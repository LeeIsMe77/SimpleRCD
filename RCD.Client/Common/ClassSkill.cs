namespace RCD.Client.Common {

	#region Directives
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using RCD.Common;
	#endregion

	public class ClassSkill {

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

}