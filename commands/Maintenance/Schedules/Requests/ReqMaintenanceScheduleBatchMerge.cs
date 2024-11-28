using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqMaintenanceScheduleBatchMerge : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamMaintenanceScheduleMerge> maintenanceSchedules { get; set; }
	}
}