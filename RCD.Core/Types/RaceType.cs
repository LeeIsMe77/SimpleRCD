namespace RCD.Core.Types {

	#region Directives
	using System;
	using System.ComponentModel.DataAnnotations;
	#endregion

	/// <summary>
	/// Enumeration representing which side of the race war the levels should be calculated for.
	/// </summary>
	[Flags]
	public enum RaceType {
		/// <summary>
		/// The light side of the race war, including Boernings, Dwarves, Elves, Hobbits, and Humans
		/// </summary>
		[Display(Name = @"Light")]
		Light = 0x1,
		/// <summary>
		/// The dark side, Uruk-Hai
		/// </summary>
		[Display(Name = @"Uruk-Hai")]
		UrukHai = 0x2,
		/// <summary>
		/// Orc-Hai
		/// </summary>
		[Display(Name = @"Orc-Hai")]
		OrcHai = 0x4,
		/// <summary>
		/// Uruk-Lhuth
		/// </summary>
		[Display(Name = @"Uruk-Lhuth")]
		UrukLhuth = 0x8,
		/// <summary>
		/// Uruk-Lhuth
		/// </summary>
		[Display(Name = @"Troll")]
		Troll = 0x256
	}

}
