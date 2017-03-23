namespace RCD.WPFClient {

	#region Directives
	using System;
	using System.Windows;
	using ViewModels;
	using Views;
	#endregion

	public static class Program {
		
		[STAThread]
		public static void RunWPFClient() {
			var application = new Application();
			var rcdManagerViewModel = new RCDManagerViewModel(new Core.Common.ConfigurationManager());
			var rcdManager = new RCDManager(rcdManagerViewModel);
			//rcdManager.DataContext = rcdManagerViewModel;
			application.Run(rcdManager);
		}

	}

}
