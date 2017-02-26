namespace RCD.Client.Common {

	#region Directives
	using System;
	#endregion

	/// <summary>
	/// Utility class for calculating character coefficient points and levels.
	/// </summary>
	public static class ClassProfileUtility {

		#region Calculate Character Class Level

		/// <summary>
		/// Calculates the class level.
		/// </summary>
		/// <param name="classPoints">The class points.</param>
		/// <param name="characterRace">The character race.</param>
		/// <param name="characterClass">The character class.</param>
		/// <returns>System.Int32.</returns>
		public static double CalculateClassLevel(int classPoints) {
			return CalculateClassLevel(CalculateCoefficientFromPoints(classPoints));
		}

		/// <summary>
		/// Calculates the class level.
		/// </summary>
		/// <param name="coefficientPoints">The coefficient points.</param>
		/// <returns>System.Int32.</returns>
		private static double CalculateClassLevel(double coefficientPoints) {
			return coefficientPoints / 100 * 30;
		}

		#endregion

		#region Calculate Character Class Points

		/// <summary>
		/// Calculates the class points.
		/// </summary>
		/// <param name="classLevel">The class level.</param>
		/// <param name="characterRace">The character race.</param>
		/// <param name="characterClass">The character class.</param>
		/// <returns>System.Int32.</returns>
		public static int CalculateClassPoints(int classLevel) {
			return ClassProfileUtility.CalculateClassPoints(
				ClassProfileUtility.CalculateCoefficientFromLevel(classLevel)
				);
		}

		/// <summary>
		/// Calculates the class points.
		/// </summary>
		/// <param name="coefficientPoints">The coefficient points.</param>
		/// <returns>System.Int32.</returns>
		private static int CalculateClassPoints(double coefficientPoints) {
			var tempPoints = ((coefficientPoints / 10) * (coefficientPoints / 10));
			return (tempPoints - .01d > Math.Floor(tempPoints) && tempPoints < tempPoints + 1)
				? (int)Math.Ceiling(tempPoints)
				: (int)Math.Floor(tempPoints)
				;
		}

		#endregion

		#region Calculate Character Coefficient

		/// <summary>
		/// Calculates the coefficient from level.
		/// </summary>
		/// <param name="classLevel">The class level.</param>
		/// <returns>System.Double.</returns>
		private static double CalculateCoefficientFromLevel(int classLevel) {
			return classLevel / 30d * 100d;
		}

		/// <summary>
		/// Calculates the coefficient from points.
		/// </summary>
		/// <param name="classPoints">The class points.</param>
		/// <returns>System.Double.</returns>
		private static double CalculateCoefficientFromPoints(int classPoints) {
			return Math.Sqrt(classPoints) * 10;
		}

		#endregion

	}

}