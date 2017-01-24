namespace SimpleRCD.Common {

	#region Directives
	using System;
	#endregion

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
