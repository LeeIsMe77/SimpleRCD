namespace RCD.Core.Cache {

	#region Directives
	using System.Collections.Generic;
	using Core.Common;
	using Core.Types;
	#endregion

	public static class RCDCache {

		#region Fields

		/// <summary>
		/// A list of all <see cref="MysticPower"/> objects which represent learnable skills in Return of the Shadow.
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
					new MageSpell(@"Magic Missile" , 0, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 5, 12, 6, 15),
					new MageSpell(@"Word of Pain", 0, RaceType.UrukLhuth, 5, 12, 6, 15),
					new MageSpell(@"Create Light" , 1, RaceType.Light, 4, 31, 5, 19),
					new MageSpell(@"Locate Living" , 2, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai | RaceType.UrukLhuth, 8, 34, 5, 20),
					new MageSpell(@"Shield" , 2, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai | RaceType.UrukLhuth, 4, 25, 5, 20),
					new MageSpell(@"Cure Self" , 3, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai | RaceType.UrukLhuth, 16, 34, 12, 10),
					new MageSpell(@"Detect Evil" , 3, RaceType.Light, 5, 31, 3, 31),
					new MageSpell(@"Chill Ray" , 4, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 6, 35, 8, 15),
					new MageSpell(@"Leach", 4, RaceType.UrukLhuth, 6, 35, 8, 15),
					new MageSpell(@"Blink" , 5, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai | RaceType.UrukLhuth, 5, 36, 5, 23),
					new MageSpell(@"Word of Sight", 5, RaceType.UrukLhuth, 1, 16, 3, 33),
					new MageSpell(@"Flash" , 6, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 3, 23, 5, 14),
					new MageSpell(@"Reveal Life" , 6, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 1, 16, 3, 33),
					new MageSpell(@"Word of Shock", 6, RaceType.UrukLhuth, 3, 23, 5, 14),
					new MageSpell(@"Lightning Bolt" , 7, RaceType.Light, 17, 34, 10, 15),
					new MageSpell(@"Dark Bolt" , 9, RaceType.UrukHai | RaceType.UrukLhuth, 8, 34, 12, 16),
					new MageSpell(@"Vitalize Self" , 9, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai | RaceType.UrukLhuth, 16, 34, 12, 16),
					new MageSpell(@"Black Arrow", 11, RaceType.UrukLhuth, 10, 33, 13, 17),
					new MageSpell(@"Firebolt" , 11, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 10, 33, 13, 17),
					new MageSpell(@"Cone of Cold" , 14, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 9, 34, 15, 19),
					new MageSpell(@"Word of Agony", 14, RaceType.UrukLhuth, 9, 34, 15, 19),
					new MageSpell(@"Summon" , 17, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai | RaceType.UrukLhuth, 16, 34, 50, 19),
					new MageSpell(@"Identify" , 18, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai | RaceType.UrukLhuth, 22, 36, 70, 19),
					new MageSpell(@"Lightning Strike" , 19, RaceType.Light, 12, 33, 10, 27),
					new MageSpell(@"Earthquake" , 20, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 9, 34, 15, 25),
					new MageSpell(@"Shout of Pain", 20, RaceType.UrukLhuth, 9, 34, 15, 25),
					new MageSpell(@"Fireball" , 21, RaceType.Light, 14, 33, 18, 25),
					new MageSpell(@"Searing Darkness" , 21, RaceType.UrukHai, 14, 31, 18, 25),
					new MageSpell(@"Spear of Darkness", 21, RaceType.UrukLhuth, 13, 33, 16, 26),
					new MageSpell(@"Relocate" , 24, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai | RaceType.UrukLhuth, 32, 36, 30, 25)
				}
			);

			#endregion

			#region Ranger Skills

			Skills.AddRange(
				new[] {
					new RangerSkill(@"Cover" , 0, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0, SpecializationType.Stealth),
					new RangerSkill(@"Ride" , 0, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai | RaceType.UrukLhuth, 0, 0),
					new RangerSkill(@"Search" , 0, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai | RaceType.UrukLhuth, 0, 0),
					new RangerSkill(@"Stalk" , 0, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0, SpecializationType.Stealth),
					new RangerSkill(@"Track" , 0, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai | RaceType.UrukLhuth, 0, 0),
					new RangerSkill(@"Whistle" , 0, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0, SpecializationType.Animals),
					new RangerSkill(@"Awareness" , 1, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai | RaceType.UrukLhuth, 0, 0),
					new RangerSkill(@"Archery" , 1, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0),
					new RangerSkill(@"Calm" , 1, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0),
					new RangerSkill(@"Dodge" , 1, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0),
					new RangerSkill(@"Gather Herbs" , 1, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0),
					new RangerSkill(@"Pick Lock" , 1, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai | RaceType.UrukLhuth, 0, 0),
					new RangerSkill(@"Hide" , 2, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0),
					new RangerSkill(@"Stealth" , 2, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0),
					new RangerSkill(@"Tame" , 2, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0),
					new RangerSkill(@"Swim" , 2, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0),
					new RangerSkill(@"Fast Attack" , 3, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0),
					new RangerSkill(@"Sneak" , 5, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0),
					new RangerSkill(@"Ambush" , 6, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0),
					new RangerSkill(@"Travelling" , 6, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0),
					new RangerSkill(@"Animals" , 10, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0),
					new RangerSkill(@"Riposte" , 20, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0)
				}
			);

			#endregion

			#region Warrior Skills

			Skills.AddRange(
				new[] {
					new WarriorSkill(@"Axes" , 0, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0),
					new WarriorSkill(@"Concussion" , 0, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai | RaceType.UrukLhuth, 0, 0),
					new WarriorSkill(@"Parry" , 0, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0),
					new WarriorSkill(@"Piercing" , 0, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0),
					new WarriorSkill(@"Slashing" , 0, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai | RaceType.UrukLhuth, 0, 0),
					new WarriorSkill(@"Spears" , 0, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0),
					new WarriorSkill(@"Whips/Flails" , 0, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0),
					new WarriorSkill(@"Wild Swing" , 0, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0, SpecializationType.WildFighting),
					new WarriorSkill(@"Two-handed" , 1, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0),
					new WarriorSkill(@"Weapon Mastery" , 1, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0),
					new WarriorSkill(@"Kick" , 2, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0),
					new WarriorSkill(@"Rescue" , 3, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0),
					new WarriorSkill(@"Bash" , 5, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0),
					new WarriorSkill(@"Berserk" , 7, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0),
					new WarriorSkill(@"Find Weakness" , 20, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0)
				}
			);

			#endregion

			#region Mystic Skills

			Skills.AddRange(
				new[] {
					new MysticPower(@"Confuse", 0, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0, SpecializationType.Illusion),
					new MysticPower(@"Curse", 1, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0),
					new MysticPower(@"Detect Hidden", 1, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0),
					new MysticPower(@"Detect Magic", 1, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai | RaceType.UrukLhuth, 0, 0),
					new MysticPower(@"Protection", 1, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0, SpecializationType.Protection),
					new MysticPower(@"Revive", 1, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0),
					new MysticPower(@"Evasion", 2, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0),
					new MysticPower(@"Hallucinate", 3, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0),
					new MysticPower(@"Mind Block", 3, RaceType.UrukHai | RaceType.OrcHai | RaceType.UrukLhuth, 0, 0),
					new MysticPower(@"Resist Poison", 3, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai | RaceType.UrukLhuth, 0, 0),
					new MysticPower(@"Curing Saturation", 4, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0),
					new MysticPower(@"Haze", 5, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0),
					new MysticPower(@"Insight", 6, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0),
					new MysticPower(@"Pragmatism", 6, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0),
					new MysticPower(@"Restlessness", 6, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0),
					new MysticPower(@"Remove Poison", 8, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0),
					new MysticPower(@"Slow Digestion", 11, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai | RaceType.UrukLhuth, 0, 0),
					new MysticPower(@"Vitality", 11, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0),
					new MysticPower(@"Fear", 12, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0),
					new MysticPower(@"Dispel Regeneration", 13, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0),
					new MysticPower(@"Divination", 13, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0),
					new MysticPower(@"Poison", 14, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0),
					new MysticPower(@"Regeneration", 15, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0),
					new MysticPower(@"Sanctuary", 16, RaceType.Light, 0, 0),
					new MysticPower(@"Infravision", 17, RaceType.Light, 0, 0),
					new MysticPower(@"Terror", 18, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0),
					new MysticPower(@"Enchant Weapon", 20, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0),
					new MysticPower(@"Death Ward", 20, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0),
					new MysticPower(@"Guardian", 27, RaceType.Light | RaceType.UrukHai | RaceType.OrcHai, 0, 0, SpecializationType.Guardian)
				}
			);

			#endregion

		}

		#endregion

	}

}
