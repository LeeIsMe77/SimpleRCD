namespace RCD.WPFClient.Converters {

	#region Directives
	using System;
	using System.Globalization;
	using System.Windows.Data;
	using Core.Common;
	using Core.Types;
	using ViewModels;
	#endregion

	public sealed class SkillApplicabilityConverter
		: IMultiValueConverter {

		/// <summary>
		/// Converts source values to a value for the binding target. The data binding engine calls this method when it propagates the values from source bindings to the binding target.
		/// </summary>
		/// <param name="values">The array of values that the source bindings in the <see cref="T:System.Windows.Data.MultiBinding" /> produces. The value <see cref="F:System.Windows.DependencyProperty.UnsetValue" /> indicates that the source binding has no value to provide for conversion.</param>
		/// <param name="targetType">The type of the binding target property.</param>
		/// <param name="parameter">The converter parameter to use.</param>
		/// <param name="culture">The culture to use in the converter.</param>
		/// <returns>A converted value.If the method returns null, the valid null value is used.A return value of <see cref="T:System.Windows.DependencyProperty" />.<see cref="F:System.Windows.DependencyProperty.UnsetValue" /> indicates that the converter did not produce a value, and that the binding will use the <see cref="P:System.Windows.Data.BindingBase.FallbackValue" /> if it is available, or else will use the default value.A return value of <see cref="T:System.Windows.Data.Binding" />.<see cref="F:System.Windows.Data.Binding.DoNothing" /> indicates that the binding does not transfer the value or use the <see cref="P:System.Windows.Data.BindingBase.FallbackValue" /> or the default value.</returns>
		/// <remarks>
		/// 2 values are expected for this converter to determine whether or not the supplied coefficients are capable of learning the skill.
		/// <see cref="ClassProfile"/> and <see cref="ClassSkill"/>
		/// </remarks>
		public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture) {

			//We expect 2 values.
			if (values.Length < 2) {
				return false;
			}

			if (values[0] == null || values[1] == null) {
				return false;
			}

			var valueAsViewModel = values[0] as RCDManagerViewModel;
			if (valueAsViewModel == null) {
				return false;
			}

			var valueAsClassSkill = values[1] as ClassSkill;
			if (valueAsClassSkill == null) {
				return false;
			}

			if ((valueAsViewModel.Race & valueAsClassSkill.Race) != valueAsViewModel.Race) {
				return false;
			}

			var characterClassLevel = 0;
			switch (valueAsClassSkill.Class) {
				case ClassType.Mage:
					characterClassLevel = valueAsViewModel.MageModifiedLevel;
					break;
				case ClassType.Mystic:
					characterClassLevel = valueAsViewModel.MysticModifiedLevel;
					break;
				case ClassType.Ranger:
					characterClassLevel = valueAsViewModel.RangerModifiedLevel;
					break;
				case ClassType.Warrior:
					characterClassLevel = valueAsViewModel.WarriorModifiedLevel;
					break;
			}

			return characterClassLevel >= valueAsClassSkill.SkillLevel;
		}

		/// <summary>
		/// Converts a binding target value to the source binding values.
		/// </summary>
		/// <param name="value">The value that the binding target produces.</param>
		/// <param name="targetTypes">The array of types to convert to. The array length indicates the number and types of values that are suggested for the method to return.</param>
		/// <param name="parameter">The converter parameter to use.</param>
		/// <param name="culture">The culture to use in the converter.</param>
		/// <returns>An array of values that have been converted from the target value back to the source values.</returns>
		/// <exception cref="NotImplementedException"></exception>
		public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture) {
			throw new NotImplementedException();
		}
	}

}
