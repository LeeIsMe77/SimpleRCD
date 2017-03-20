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


		#region ClientApplicationContext

		/// <summary>Provides access to application configuration options</summary>
		private static ApplicationContext _clientApplicationContext;

		/// <summary>Makes the applications custom context available so that the primary form may switch another form to primary</summary>
		internal static ApplicationContext ClientApplicationContext {
			get { return _clientApplicationContext ?? (_clientApplicationContext = new ApplicationContext()); }
		}

		#endregion


		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main(string[] args) {

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Form form = null;
			try {

				if (args.Length == 0) {
					form = new RCDForm();
				}

				foreach (var argument in args) {

					switch (argument.ToUpper()) {
						case @"/WPF":
							RCD.WPFClient.Program.RunWPFClient();
							break;
						default:
							form = new RCDForm();
							break;
					}
				}

				if (form == null) return;

				ClientApplicationContext.MainForm = form;
				Application.Run(ClientApplicationContext);
				form = null;
				
			}
			catch { }
			finally {
				form?.Dispose();
			}
		}
	}
}
