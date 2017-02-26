namespace RCD.Client {

	#region Directives
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using Common;
	#endregion

	public static class RCDCache {

		public static List<ClassSkill> MageSkills;
		//public static List<CharacterSkill> WarriorSkills;
		//public static List<CharacterSkill> RangerSkills;
		//public static List<CharacterSkill> MysticSkills;

		static RCDCache() {
			MageSkills = new List<ClassSkill> {
				//Mage Skills...
				new ClassSkill(@"Magic Missile", ClassType.Mage, 0, RaceType.All),
				new ClassSkill(@"Create Light", ClassType.Mage, 1, RaceType.Whitie),
				new ClassSkill(@"Locate Living", ClassType.Mage, 2, RaceType.All),
				new ClassSkill(@"Shield", ClassType.Mage, 2, RaceType.All),
				new ClassSkill(@"Cure Self", ClassType.Mage, 3, RaceType.All),
				new ClassSkill(@"Detect Evil", ClassType.Mage, 3, RaceType.Whitie),
				new ClassSkill(@"Chill Ray", ClassType.Mage, 4, RaceType.All),
				new ClassSkill(@"Blink", ClassType.Mage, 5, RaceType.All),
				new ClassSkill(@"Reveal Life", ClassType.Mage, 6, RaceType.All),
				new ClassSkill(@"Flash", ClassType.Mage, 0, RaceType.All),
				new ClassSkill(@"Lightning Bolt", ClassType.Mage, 7, RaceType.Whitie),
				new ClassSkill(@"Dark Bolt", ClassType.Mage, 9, RaceType.UrukHai),
				new ClassSkill(@"Vitalize Self", ClassType.Mage, 9, RaceType.All),
				new ClassSkill(@"Firebolt", ClassType.Mage, 11, RaceType.All),
				new ClassSkill(@"Cone of Cold", ClassType.Mage, 14, RaceType.All),
				new ClassSkill(@"Identify", ClassType.Mage, 18, RaceType.All),
				new ClassSkill(@"Lightning Strike", ClassType.Mage, 19, RaceType.Whitie),
				new ClassSkill(@"Earthquake", ClassType.Mage, 20, RaceType.All),
				new ClassSkill(@"Fireball", ClassType.Mage, 21, RaceType.Whitie),
				new ClassSkill(@"Searing Darkness", ClassType.Mage, 21, RaceType.UrukHai),
				new ClassSkill(@"Relocate", ClassType.Mage, 24, RaceType.All)
			};
		}
		
	}

}
