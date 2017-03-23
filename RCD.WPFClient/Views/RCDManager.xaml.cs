namespace RCD.WPFClient.Views {

	#region Directives
	using System.Windows;
	using System.Windows.Interop;
	using System.Windows.Media.Imaging;
	using ViewModels;
	#endregion

	/// <summary>
	/// Interaction logic for RCDManager.xaml
	/// </summary>
	public partial class RCDManager
		: Window {

		private readonly RCDManagerViewModel _viewModel;
		
		public RCDManager(RCDManagerViewModel viewModel) {
			InitializeComponent();
			this.Icon = Imaging.CreateBitmapSourceFromHIcon(
				RCD.WPFClient.Properties.Resources.AssemblyIcon.Handle,
				Int32Rect.Empty,
				BitmapSizeOptions.FromEmptyOptions()
				);
			_viewModel = viewModel;
			this.Closing += _viewModel.window_Closing;
			this.DataContext = _viewModel;
		}

	}

}
