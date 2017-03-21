namespace RCD.Core.Cache {

	#region Directives
	using System.Collections.Generic;
	using Core.Common;
	using Core.Types;
	#endregion

	public static class RCDCache {

		#region Fields

		/// <summary>
		/// A list of all <see cref="ClassSkill"/> objects which represent learnable skills in Return of the Shadow.
		/// </summary>
		public static ClassSkillCollection Skills;

		#endregion

		#region Constructor

		/// <summary>
		/// Initializes static members of the <see cref="RCDCache"/> class.
		/// </summary>
		static RCDCache() {

			Skills = new ClassSkillCollection();
			
			#region Mage Skills

			Skills.AddRange(
				new[] {
					new ClassSkill(@"Magic Missile", ClassType.Mage, 0, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Create Light", ClassType.Mage, 1, RaceType.Light),
					new ClassSkill(@"Locate Living", ClassType.Mage, 2, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Shield", ClassType.Mage, 2, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Cure Self", ClassType.Mage, 3, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Detect Evil", ClassType.Mage, 3, RaceType.Light),
					new ClassSkill(@"Chill Ray", ClassType.Mage, 4, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Blink", ClassType.Mage, 5, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Reveal Life", ClassType.Mage, 6, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Flash", ClassType.Mage, 6, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Lightning Bolt", ClassType.Mage, 7, RaceType.Light),
					new ClassSkill(@"Dark Bolt", ClassType.Mage, 9, RaceType.Uruk),
					new ClassSkill(@"Vitalize Self", ClassType.Mage, 9, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Firebolt", ClassType.Mage, 11, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Cone of Cold", ClassType.Mage, 14, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Summon", ClassType.Mage, 17, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Identify", ClassType.Mage, 18, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Lightning Strike", ClassType.Mage, 19, RaceType.Light),
					new ClassSkill(@"Earthquake", ClassType.Mage, 20, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Fireball", ClassType.Mage, 21, RaceType.Light),
					new ClassSkill(@"Searing Darkness", ClassType.Mage, 21, RaceType.Uruk),
					new ClassSkill(@"Relocate", ClassType.Mage, 24, RaceType.Light | RaceType.Uruk | RaceType.Orc)
				}
			);

			#endregion

			#region Ranger Skills

			Skills.AddRange(
				new[] {
					new ClassSkill(@"Cover", ClassType.Ranger, 0, RaceType.Light | RaceType.Uruk | RaceType.Orc, SpecializationType.Stealth),
					new ClassSkill(@"Ride", ClassType.Ranger, 0, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Search", ClassType.Ranger, 0, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Stalk", ClassType.Ranger, 0, RaceType.Light | RaceType.Uruk | RaceType.Orc, SpecializationType.Stealth),
					new ClassSkill(@"Track", ClassType.Ranger, 0, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Whistle", ClassType.Ranger, 0, RaceType.Light | RaceType.Uruk | RaceType.Orc, SpecializationType.Animals),
					new ClassSkill(@"Awareness", ClassType.Ranger, 1, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Archery", ClassType.Ranger, 1, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Calm", ClassType.Ranger, 1, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Dodge", ClassType.Ranger, 1, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Gather Herbs", ClassType.Ranger, 1, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Pick Lock", ClassType.Ranger, 1, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Hide", ClassType.Ranger, 2, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Stealth", ClassType.Ranger, 2, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Tame", ClassType.Ranger, 2, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Swim", ClassType.Ranger, 2, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Fast Attack", ClassType.Ranger, 3, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Sneak", ClassType.Ranger, 5, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Ambush", ClassType.Ranger, 6, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Travelling", ClassType.Ranger, 6, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Animals", ClassType.Ranger, 10, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Riposte", ClassType.Ranger, 20, RaceType.Light | RaceType.Uruk | RaceType.Orc)
				}
			);

			#endregion

			#region Warrior Skills

			Skills.AddRange(
				new[] {
					new ClassSkill(@"Axes", ClassType.Warrior, 0, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Concussion", ClassType.Warrior, 0, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Parry", ClassType.Warrior, 0, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Piercing", ClassType.Warrior, 0, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Slashing", ClassType.Warrior, 0, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Spears", ClassType.Warrior, 0, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Whips/Flails", ClassType.Warrior, 0, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Wild Swing", ClassType.Warrior, 0, RaceType.Light | RaceType.Uruk | RaceType.Orc, SpecializationType.WildFighting),
					new ClassSkill(@"Two-handed", ClassType.Warrior, 1, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Weapon Mastery", ClassType.Warrior, 1, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Kick", ClassType.Warrior, 2, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Rescue", ClassType.Warrior, 3, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Bash", ClassType.Warrior, 5, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Berserk", ClassType.Warrior, 7, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Find Weakness", ClassType.Warrior, 20, RaceType.Light | RaceType.Uruk | RaceType.Orc)
				}
			);

			#endregion

			#region Mystic Skills

			Skills.AddRange(
				new[] {
					new ClassSkill(@"Confuse", ClassType.Mystic, 0, RaceType.Light | RaceType.Uruk | RaceType.Orc, SpecializationType.Illusion),
					new ClassSkill(@"Curse", ClassType.Mystic, 1, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Detect Hidden", ClassType.Mystic, 1, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Detect Magic", ClassType.Mystic, 1, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Protection", ClassType.Mystic, 1, RaceType.Light | RaceType.Uruk | RaceType.Orc, SpecializationType.Protection),
					new ClassSkill(@"Revive", ClassType.Mystic, 1, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Evasion", ClassType.Mystic, 2, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Hallucinate", ClassType.Mystic, 3, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Mind Block", ClassType.Mystic, 3, RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Resist Poison", ClassType.Mystic, 3, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Curing Saturation", ClassType.Mystic, 4, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Haze", ClassType.Mystic, 5, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Insight", ClassType.Mystic, 6, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Pragmatism", ClassType.Mystic, 6, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Restlessness", ClassType.Mystic, 6, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Remove Poison", ClassType.Mystic, 8, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Slow Digestion", ClassType.Mystic, 11, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Vitality", ClassType.Mystic, 11, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Fear", ClassType.Mystic, 12, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Dispel Regeneration", ClassType.Mystic, 13, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Divination", ClassType.Mystic, 13, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Poison", ClassType.Mystic, 14, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Regeneration", ClassType.Mystic, 15, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Sanctuary", ClassType.Mystic, 16, RaceType.Light),
					new ClassSkill(@"Infravision", ClassType.Mystic, 17, RaceType.Light),
					new ClassSkill(@"Terror", ClassType.Mystic, 18, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Enchant Weapon", ClassType.Mystic, 20, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Death Ward", ClassType.Mystic, 20, RaceType.Light | RaceType.Uruk | RaceType.Orc),
					new ClassSkill(@"Guardian", ClassType.Mystic, 27, RaceType.Light | RaceType.Uruk | RaceType.Orc, SpecializationType.Guardian)
				}
			);

			#endregion

		}

		#endregion

	}

}
