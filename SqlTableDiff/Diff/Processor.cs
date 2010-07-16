using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace SqlTableDiff.Diff
{
	class Processor
	{
		public Processor()
		{
			Source = new DbInfo();
			Destination = new DbInfo();
			Options = new OptionsInfo();
			ReportName = "Report.txt";
			GenerateSql = true;
		}

		#region Parameters

		public DbInfo Source { get; set; }
		public DbInfo Destination { get; set; }
		public OptionsInfo Options { get; set; }

		public string OutputFolder { get; set; }
		public string OutputTableName { get; set; }
		public bool DropOutputTable { get; set; }

		public string ReportName { get; set; }
		public string TableName { get; set; }

		public bool GenerateSql { get; set; }
		public int? SqlStatementsPerFile { get; set; }

		#endregion

		#region Return Values

		public int ExitCode { get { return _exitCode; } }
		public string ExitStatus { get { return _exitStatus; } }
		public string ReportFile { get { return _reportFile; } }
		public string StandardOutput { get { return _standardOutput; } }
		public string TableScriptFile { get { return _tableScriptFile; } }

		int _exitCode;
		string _exitStatus;
		string _reportFile;
		string _standardOutput;
		string _tableScriptFile;

		#endregion

		public void Execute()
		{
			_exitCode = 0;
			_exitStatus = "";
			_reportFile = System.IO.Path.Combine(OutputFolder, ReportName);
			_standardOutput = "";
			_tableScriptFile = System.IO.Path.Combine(OutputFolder, TableName + ".sql");

			var args = BuildArgs();

			Process proc = new Process();
			proc.StartInfo = new ProcessStartInfo(Tools.TableDiff, args);
			proc.StartInfo.UseShellExecute = false;
			proc.StartInfo.RedirectStandardOutput = true;
			proc.StartInfo.CreateNoWindow = true;
			proc.Start();
			System.IO.StreamReader std = proc.StandardOutput;
			do
			{
				proc.WaitForExit(100);
				System.Windows.Forms.Application.DoEvents();
			}
			while (!proc.HasExited);

			_exitCode = proc.ExitCode;
			_exitStatus = GetExitStatus(_exitCode);
			_standardOutput = std.ReadToEnd();

			// Adding an extra newline to the file helps readability when the same report file gets appended to over and over again.
			System.IO.File.AppendAllText(_reportFile, Environment.NewLine);
		}

		string BuildArgs()
		{
			// Source
			var str = "-sourceserver \"" + Source.Server + "\" " + "-sourcedatabase \"" + Source.Name + "\" ";

			str += "-sourceschema \"" + Source.Schema + "\" " + "-sourcetable \"" + TableName + "\" ";
			if (Source.AuthType != DbAuthType.Windows)
			{
				str += "-sourceuser \"" + Source.AuthUser + "\" " + "-sourcepassword \"" + Source.AuthPass + "\" ";
			}
			if (Source.LockTable)
			{
				str += "-sourcelocked ";
			}
			// Destination
			str += "-destinationserver \"" + Destination.Server + "\" " + "-destinationdatabase \"" + Destination.Name + "\" ";

			str += "-destinationschema \"" + Destination.Schema + "\" " + "-destinationtable \"" + TableName + "\" ";
			if (Destination.AuthType != DbAuthType.Windows)
			{
				str += "-destinationuser \"" + Destination.AuthUser + "\" " + "-destinationpassword \"" + Destination.AuthPass + "\" ";
			}
			if (Destination.LockTable)
			{
				str += "-destinationlocked ";
			}
			// Advanced
			if (Options.LargeObjectBytes.HasValue)
			{
				str += "-b " + Options.LargeObjectBytes.ToString() + " ";
			}
			if (Options.ColumnCompare)
			{
				str += "-c ";
			}
			// Output
			if (!String.IsNullOrEmpty(OutputTableName))
			{
				str += "-et \"" + OutputTableName + "\" ";
				if (DropOutputTable) str += "-dt ";
			}
			str += "-o \"" + _reportFile + "\" ";
			if (GenerateSql)
			{
				str += "-f ";
				str += "\"" + _tableScriptFile + "\" ";
			}
			if (SqlStatementsPerFile.HasValue)
			{
			    str += "-bf " + SqlStatementsPerFile.ToString() + " ";
			}
			// Advanced 2
			if (Options.FastCompare)
			{
				str += "-q ";
			}
			if (Options.RetryCount.HasValue)
			{
				str += "-rc " + Options.RetryCount.ToString() + " ";
			}
			if (Options.RetryInterval.HasValue)
			{
				str += "-ri " + Options.RetryInterval.ToString() + " ";
			}
			if (Options.StrictSchema)
			{
				str += "-strict ";
			}
			if (Options.ConnectTimeout.HasValue)
			{
				str += "-t " + Options.ConnectTimeout.ToString() + " ";
			}
			return str;
		}

		string GetExitStatus(int exitCode)
		{
			switch (exitCode)
			{
			case 0:
				return "Identical";
			case 1:
				return "Error";
			case 2:
				return "Differences";
			}
			return "Unknown";
		}
	}
}
