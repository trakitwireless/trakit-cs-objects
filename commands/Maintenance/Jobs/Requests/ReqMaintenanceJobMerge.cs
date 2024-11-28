using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Creates a new or updates an existing <see cref="MaintenanceJob"/>.
	/// </summary>
	public class ReqMaintenanceJobMerge : Request, IReqSingle {
		/// <summary>
		/// Parameters given to create or update a <see cref="MaintenanceJob"/>.
		/// </summary>
		public ParamMaintenanceJobMerge maintenanceJob { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.maintenanceJob?.id?.ToString() ?? "";
	}
}