namespace RCD.Client.Management {

	#region Directives
	using System;
	using System.Windows.Forms;
	#endregion

	public partial class About
		: Form {

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="About"/> class.
		/// </summary>
		public About() {
			InitializeComponent();
			this.Icon = RCD.Properties.Resources.AssemblyIcon;
		}

		#endregion

		#region Control Events

		/// <summary>
		/// Handles the Click event of the close control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void close_Click(object sender, EventArgs e) {
			this.DialogResult = DialogResult.OK;
		}

		#endregion

	}
}
