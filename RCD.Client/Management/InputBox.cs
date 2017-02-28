using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RCD.Client.Management {

	public partial class InputBox
		: Form {

		#region Static

		/// <summary>
		/// Shows the dialog.
		/// </summary>
		/// <param name="owner">The owner.</param>
		/// <param name="title">The title.</param>
		/// <param name="valueFor">The value for.</param>
		/// <param name="defaultValue">The default value.</param>
		/// <returns>System.String.</returns>
		public static string ShowDialog(IWin32Window owner, string title, string valueFor, string defaultValue = null) {
			using (var form = new InputBox(title, valueFor, defaultValue)) {
				if (form.ShowDialog(owner) == DialogResult.OK) {
					return form.input.Text;
				}
				return defaultValue ?? string.Empty;
			}
		}

		#endregion

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="InputBox"/> class.
		/// </summary>
		/// <param name="title">The title.</param>
		/// <param name="valueFor">The value for.</param>
		/// <param name="defaultValue">The default value.</param>
		private InputBox(string title, string valueFor, string defaultValue = null) {
			InitializeComponent();
			this.Icon = RCD.Properties.Resources.AssemblyIcon;
			this.Text = title;
			this.inputLabel.Text = $"{valueFor}:";
			this.input.Text = defaultValue ?? string.Empty;
		}

		#endregion

		#region Control Events

		/// <summary>
		/// Handles the Click event of the ok control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ok_Click(object sender, EventArgs e) {
			this.DialogResult = DialogResult.OK;
		}

		#endregion

	}

}
