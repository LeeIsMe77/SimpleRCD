using System;

namespace SimpleRCD.Management {

	/// <summary>
	/// Enumeration representing which side of the race war the levels should be calculated for.
	/// </summary>
	[Flags]
	public enum CharacterRace {
		Whitie,
		UrukHai,
		Orc,
		All = -1
	}

}
