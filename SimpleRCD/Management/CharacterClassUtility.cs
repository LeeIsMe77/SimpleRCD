namespace SimpleRCD.Management {

	#region Directives
	using System;
	#endregion

	/// <summary>
	/// Utility class for calculating character coefficient points and levels.
	/// </summary>
	public static class CharacterClassUtility {

		/// <summary>
		/// Calculates the coefficient points.
		/// </summary>
		/// <param name="level">The level.</param>
		/// <returns>System.Double.</returns>
		public static double CalculateCoefficientPoints(int level) {
			return level / 30d * 100d;
		}

		/// <summary>
		/// Calculates the points used.
		/// </summary>
		/// <param name="coefficient">The coefficient.</param>
		/// <returns>System.Int32.</returns>
		public static int CalculatePointsUsed(double coefficient) {
			var tempPoints = ((coefficient / 10) * (coefficient / 10));
			return (tempPoints - .01d > Math.Floor(tempPoints) && tempPoints < tempPoints + 1) 
				? (int)Math.Ceiling(tempPoints) 
				: (int)Math.Floor(tempPoints)
				;			
		}

		/// <summary>
		/// Calculates the points used.
		/// </summary>
		/// <param name="level">The level.</param>
		/// <returns>System.Int32.</returns>
		public static int CalculatePointsUsed(int level) {
			return CharacterClassUtility.CalculatePointsUsed(
				CharacterClassUtility.CalculateCoefficientPoints(level)
				);
		}
		
	}

}