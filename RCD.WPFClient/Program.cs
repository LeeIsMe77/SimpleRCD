namespace RCD.WPFClient {

	#region Directives
	using System;
	using System.Windows;
	#endregion

	public static class Program {
		
		[STAThread]
		public static void RunWPFClient() {
			var application = new Application();
			application.Run(new RCDManager());
		}

	}

}
