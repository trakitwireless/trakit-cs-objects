using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqMaintenanceJobBatchDelete : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamId> maintenanceJobs { get; set; }
	}
}