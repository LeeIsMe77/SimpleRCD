namespace RCD.WPFClient.ValidationRules {
	
	#region Directives
	using System;
	using System.Collections.Generic;
	using System.Globalization;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using System.Windows.Controls;
	#endregion

	public class IntegerValidationRule
		: ValidationRule {
		public override ValidationResult Validate(object value, CultureInfo cultureInfo) {
			if (value is int) {
				return new ValidationResult(true, null);
			}
			return new ValidationResult(false, @"Integers only!");
		}

	}

}
