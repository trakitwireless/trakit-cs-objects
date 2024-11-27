using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqMaintenanceScheduleBatchDelete : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamId> maintenanceSchedules { get; set; }
	}
}