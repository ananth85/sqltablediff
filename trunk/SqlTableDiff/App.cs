using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SqlTableDiff
{
	static class App
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			InitializeExceptionHandling();
			InitializeExePathInfo();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainWindow());
		}

		#region Exe Path Info

		public static string ExeLocation;
		public static string ExeFolderLocation;

		static void InitializeExePathInfo()
		{
			ExeLocation = System.Reflection.Assembly.GetExecutingAssembly().Location;
			ExeFolderLocation = System.IO.Path.GetDirectoryName(ExeLocation);
		}

		#endregion

		#region Exception Handling

		static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
		{
			HandleException(e.Exception);
		}

		static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
		{
			HandleException((Exception)e.ExceptionObject);
		}

		public static void HandleException(Exception ex)
		{
			try
			{
				if
				(
					MessageBox.Show
					(
						"An application error occurred.\n" +
						"The error message is:\n\n" + ex.Message +
						"\n\nExit the program?", "Application Error",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Stop,
						MessageBoxDefaultButton.Button2

					) == DialogResult.Yes
				)
				{
					Application.Exit();
				}
			}
			catch
			{
				Application.Exit();
			}
		}

		static void InitializeExceptionHandling()
		{
			/// Setup unhandled exception handler for non-UI threads.
			AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
			/// Setup unhandled exception handler for UI thread.
			Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
			/// Set explicit exception handling policy, don't let the App.config override this handler.
			Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
		}

		#endregion
	}
}
