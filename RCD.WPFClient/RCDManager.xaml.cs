namespace RCD.WPFClient {

	#region Directives
	using System.Windows;
	using System.Windows.Interop;
	using System.Windows.Media.Imaging;
	#endregion

	/// <summary>
	/// Interaction logic for RCDManager.xaml
	/// </summary>
	public partial class RCDManager
		: Window {

		public RCDManager() {
			InitializeComponent();
			this.Icon = Imaging.CreateBitmapSourceFromHIcon(
				RCD.WPFClient.Properties.Resources.AssemblyIcon.Handle,
				Int32Rect.Empty,
				BitmapSizeOptions.FromEmptyOptions()
				);

		}

	}

}
