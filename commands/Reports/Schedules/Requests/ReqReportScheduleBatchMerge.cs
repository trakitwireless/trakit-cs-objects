using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqReportScheduleBatchMerge : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamReportScheduleMerge> reportSchedules { get; set; }
	}
}