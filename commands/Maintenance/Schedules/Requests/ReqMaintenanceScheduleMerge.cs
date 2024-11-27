using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Creates a new or updates an existing <see cref="MaintenanceSchedule"/>.
	/// </summary>
	public class ReqMaintenanceScheduleMerge : Request, IReqSingle {
		/// <summary>
		/// Parameters given to create or update a <see cref="MaintenanceSchedule"/>.
		/// </summary>
		public ParamMaintenanceScheduleMerge maintenanceSchedule { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.maintenanceSchedule?.id?.ToString() ?? "";
	}
}