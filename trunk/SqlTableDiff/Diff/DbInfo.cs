using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlTableDiff.Diff
{
	class DbInfo
	{
		public DbAuthType AuthType { get; set; }
		public string AuthUser { get; set; }
		public string AuthPass { get; set; }
		public bool LockTable { get; set; }
		public string Name { get; set; }
		public string Schema { get; set; }
		public string Server { get; set; }
	}
}
