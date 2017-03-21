﻿namespace RCD.WPFClient.Helpers {

	#region Directives
	using System;
	using System.Diagnostics;
	using System.Windows.Input;
	#endregion

	public class RelayCommand
		: ICommand {

		#region Fields
		readonly Action<object> _execute;
		readonly Predicate<object> _canExecute;
		#endregion

		#region Constructors

		/// <summary>
		/// Creates a new command that can always execute.
		/// </summary>
		/// <param name="execute">The execution logic.</param>
		public RelayCommand(Action<object> execute)
			: this(execute, null) {
		}

		/// <summary>
		/// Creates a new command.
		/// </summary>
		/// <param name="execute">The execution logic.</param>
		/// <param name="canExecute">The execution status logic.</param>
		public RelayCommand(Action<object> execute, Predicate<object> canExecute) {
			if (execute == null) {
				throw new ArgumentNullException(nameof(execute));
			}

			_execute = execute;
			_canExecute = canExecute;
		}

		#endregion

		#region ICommand Members

		[DebuggerStepThrough]
		public bool CanExecute(object parameters) {
			return _canExecute == null || _canExecute(parameters);
		}

		public event EventHandler CanExecuteChanged {
			add { CommandManager.RequerySuggested += value; }
			remove { CommandManager.RequerySuggested -= value; }
		}

		public void Execute(object parameters) {
			_execute(parameters);
		}

		#endregion

	}

}