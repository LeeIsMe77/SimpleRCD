namespace SimpleRCD.Management {

	#region Directives
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	#endregion

	public class CharacterSkill {

		#region Properties

		/// <summary>
		/// Gets the name of the skill.
		/// </summary>
		/// <value>The name of the skill.</value>
		public string SkillName { get; }

		/// <summary>
		/// Gets the type of the skill.
		/// </summary>
		/// <value>The type of the skill.</value>
		public SkillType SkillType { get; }

		/// <summary>
		/// Gets the skill level.
		/// </summary>
		/// <value>The skill level.</value>
		public int SkillLevel { get; }

		/// <summary>
		/// Gets the race.
		/// </summary>
		/// <value>The race.</value>
		public CharacterRace Race { get; }

		#endregion

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="CharacterSkill"/> class.
		/// </summary>
		/// <param name="skillName">Name of the skill.</param>
		/// <param name="skillType">Type of the skill.</param>
		/// <param name="skillLevel">The skill level.</param>
		public CharacterSkill(string skillName, SkillType skillType, int skillLevel, CharacterRace race) {
			this.SkillName = skillName;
			this.SkillType = skillType;
			this.SkillLevel = skillLevel;
			this.Race = race;
		}

		#endregion

	}

}