using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqMaintenanceJobBatchMerge : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamMaintenanceJobMerge> maintenanceJobs { get; set; }
	}
}