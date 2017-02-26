namespace RCD.Client {

	#region Directives
	using System;
	using System.Windows.Forms;
	using RCD.Client.Management;
	#endregion

	/// <summary>
	/// Class Program.
	/// </summary>
	static class Program {

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new RCDForm());
		}
	}
}
