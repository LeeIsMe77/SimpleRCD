namespace RCD.WPFClient.ValidationRules {

	#region Directives
	using System.Globalization;
	using System.Windows.Controls;
	#endregion

	public class IntegerValidationRule
		: ValidationRule {
		public override ValidationResult Validate(object value, CultureInfo cultureInfo) {
			if (value != null) {
				int parseInt;
				if (int.TryParse(value.ToString(), NumberStyles.Integer, CultureInfo.CurrentCulture, out parseInt) && parseInt >= 0) {
					return new ValidationResult(true, null);
				}
			}
			return new ValidationResult(false, $"{value} is not a valid integer.");
		}

	}

}
