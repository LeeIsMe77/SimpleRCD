namespace RCD.WPFClient.Converters {

	#region Directives
	using System;
	using System.Globalization;
	using System.Windows;
	using System.Windows.Data;
	#endregion

	/// <summary>
	/// Class PointsAvailableCutoffConverter. This class cannot be inherited.
	/// </summary>
	public sealed class CutoffConverter
		: IValueConverter {

		#region IValueConverter Members

		/// <summary>
		/// Converts a value.
		/// </summary>
		/// <param name="value">The value produced by the binding source.</param>
		/// <param name="targetType">The type of the binding target property.</param>
		/// <param name="parameter">The converter parameter to use.</param>
		/// <param name="culture">The culture to use in the converter.</param>
		/// <returns>A converted value. If the method returns null, the valid null value is used.</returns>
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {

			if (value == null || parameter == null) {
				return DependencyProperty.UnsetValue;
			}

			int pointsAvailable;
			if (!int.TryParse(value.ToString(), NumberStyles.Integer, CultureInfo.CurrentCulture, out pointsAvailable)) {
				return DependencyProperty.UnsetValue;
			}

			int cutoffValue;
			if (!int.TryParse(parameter.ToString(), NumberStyles.Integer, CultureInfo.CurrentCulture, out cutoffValue)) {
				return DependencyProperty.UnsetValue;
			}
			return pointsAvailable >= cutoffValue;
		}

		/// <summary>
		/// Converts a value.
		/// </summary>
		/// <param name="value">The value that is produced by the binding target.</param>
		/// <param name="targetType">The type to convert to.</param>
		/// <param name="parameter">The converter parameter to use.</param>
		/// <param name="culture">The culture to use in the converter.</param>
		/// <returns>A converted value. If the method returns null, the valid null value is used.</returns>
		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
			throw new NotImplementedException();
		}

		#endregion

	}
}
