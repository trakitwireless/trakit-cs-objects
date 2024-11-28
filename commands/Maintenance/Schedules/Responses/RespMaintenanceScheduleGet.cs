using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="maintenanceSchedule"/>.
	/// </summary>
	public class RespMaintenanceScheduleGet : Response {
		/// <summary>
		/// The requested <see cref="MaintenanceSchedule"/>.
		/// </summary>
		public MaintenanceSchedule maintenanceSchedule;
	}
}