using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlTableDiff.Diff
{
	enum DbAuthType
	{
		Windows,
		Sql
	}

	static class Tools
	{
		public const string TableDiff = "tablediff.exe";
	}
}
