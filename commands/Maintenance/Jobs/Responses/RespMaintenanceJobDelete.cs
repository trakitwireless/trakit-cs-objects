using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="maintenanceJob"/>.
	/// </summary>
	public class RespMaintenanceJobDelete : Response {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="MaintenanceJob"/>.
		/// </summary>
		public RespIdDeleted maintenanceJob;
	}
}