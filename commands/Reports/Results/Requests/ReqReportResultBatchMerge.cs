using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqReportResultBatchMerge : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamReportResultMerge> reportResults { get; set; }
	}
}