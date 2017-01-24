namespace SimpleRCD.Common {

	#region Directives
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	#endregion

	public static class RCDCache {

		public static List<CharacterSkill> MageSkills;
		//public static List<CharacterSkill> WarriorSkills;
		//public static List<CharacterSkill> RangerSkills;
		//public static List<CharacterSkill> MysticSkills;

		static RCDCache() {
			MageSkills = new List<CharacterSkill> {
				//Mage Skills...
				new CharacterSkill(@"Magic Missile", SkillType.Mage, 0, CharacterRace.All),
				new CharacterSkill(@"Create Light", SkillType.Mage, 1, CharacterRace.Whitie),
				new CharacterSkill(@"Locate Living", SkillType.Mage, 2, CharacterRace.All),
				new CharacterSkill(@"Shield", SkillType.Mage, 2, CharacterRace.All),
				new CharacterSkill(@"Cure Self", SkillType.Mage, 3, CharacterRace.All),
				new CharacterSkill(@"Detect Evil", SkillType.Mage, 3, CharacterRace.Whitie),
				new CharacterSkill(@"Chill Ray", SkillType.Mage, 4, CharacterRace.All),
				new CharacterSkill(@"Blink", SkillType.Mage, 5, CharacterRace.All),
				new CharacterSkill(@"Reveal Life", SkillType.Mage, 6, CharacterRace.All),
				new CharacterSkill(@"Flash", SkillType.Mage, 0, CharacterRace.All),
				new CharacterSkill(@"Lightning Bolt", SkillType.Mage, 7, CharacterRace.Whitie),
				new CharacterSkill(@"Dark Bolt", SkillType.Mage, 9, CharacterRace.UrukHai),
				new CharacterSkill(@"Vitalize Self", SkillType.Mage, 9, CharacterRace.All),
				new CharacterSkill(@"Firebolt", SkillType.Mage, 11, CharacterRace.All),
				new CharacterSkill(@"Cone of Cold", SkillType.Mage, 14, CharacterRace.All),
				new CharacterSkill(@"Identify", SkillType.Mage, 18, CharacterRace.All),
				new CharacterSkill(@"Lightning Strike", SkillType.Mage, 19, CharacterRace.Whitie),
				new CharacterSkill(@"Earthquake", SkillType.Mage, 20, CharacterRace.All),
				new CharacterSkill(@"Fireball", SkillType.Mage, 21, CharacterRace.Whitie),
				new CharacterSkill(@"Searing Darkness", SkillType.Mage, 21, CharacterRace.UrukHai),
				new CharacterSkill(@"Relocate", SkillType.Mage, 24, CharacterRace.All)
			};
		}
		
	}

}
