using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqReportResultBatchDelete : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamId> reportResults { get; set; }
	}
}