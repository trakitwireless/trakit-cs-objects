using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqReportScheduleBatchDelete : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamId> reportSchedules { get; set; }
	}
}