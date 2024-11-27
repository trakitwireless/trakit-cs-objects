using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="MaintenanceJob"/>.
	/// </summary>
	public class ReqMaintenanceJobGet : ReqMaintenanceJob, IReqIDeletable {
		/// <summary>
		/// When true, the command will also return a deleted <see cref="MaintenanceJob"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}
}