using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlTableDiff.Diff
{
	class OptionsInfo
	{
		public bool ColumnCompare { get; set; }
		public bool StrictSchema { get; set; }
		public bool FastCompare { get; set; }
		public int? LargeObjectBytes { get; set; }
		public int? ConnectTimeout { get; set; }
		public int? RetryCount { get; set; }
		public int? RetryInterval { get; set; }
	}
}
