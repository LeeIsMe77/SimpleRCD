namespace RCD.WPFClient {

	#region Directives
	using System.Windows;
	using System.Windows.Interop;
	using System.Windows.Media.Imaging;
	#endregion

	/// <summary>
	/// Interaction logic for InputBox.xaml
	/// </summary>
	public partial class InputBox 
		: Window {

		#region Static

		/// <summary>
		/// Shows the dialog.
		/// </summary>
		/// <param name="title">The title.</param>
		/// <param name="labelText">The label text.</param>
		/// <param name="dialogDefaultValue">The dialog default value.</param>
		/// <returns>System.String.</returns>
		public static string ShowDialog(string title, string labelText, string dialogDefaultValue = null) {
			var inputBox = new InputBox(title, labelText, dialogDefaultValue);
			if (inputBox.ShowDialog() == true) {
				return inputBox.textBox.Text;
			}
			return string.Empty;
		}

		#endregion
		
		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="InputBox"/> class.
		/// </summary>
		/// <param name="title">The title.</param>
		/// <param name="labelText">The label text.</param>
		/// <param name="dialogTextDefaultValue">The dialog text.</param>
		private InputBox(string title, string labelText, string dialogTextDefaultValue) {
			InitializeComponent();
			this.Icon = Imaging.CreateBitmapSourceFromHIcon(
				RCD.WPFClient.Properties.Resources.AssemblyIcon.Handle,
				Int32Rect.Empty,
				BitmapSizeOptions.FromEmptyOptions()
				);
			this.Title = title;
			this.label.Content = labelText;
			this.textBox.Text = dialogTextDefaultValue;
		}

		#endregion

		#region Control Events

		private void okay_Click(object sender, RoutedEventArgs e) {
			this.DialogResult = true;
		}

		private void cancel_Click(object sender, RoutedEventArgs e) {
			this.DialogResult = false;
		}

		#endregion

	}

}
