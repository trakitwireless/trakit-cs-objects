using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="maintenanceJob"/>.
	/// </summary>
	public class RespMaintenanceJobGet : Response {
		/// <summary>
		/// The requested <see cref="MaintenanceJob"/>.
		/// </summary>
		public MaintenanceJob maintenanceJob;
	}
}