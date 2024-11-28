using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="maintenanceSchedule"/> object.
	/// </summary>
	public abstract class ReqMaintenanceSchedule : Request, IReqSingle {
		/// <summary>
		/// An object to contain the "id" of the <see cref="MaintenanceSchedule"/>.
		/// </summary>
		public ParamId maintenanceSchedule { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.maintenanceSchedule?.id.ToString() ?? "";
	}
}