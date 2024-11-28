using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="maintenanceJob"/> object.
	/// </summary>
	public abstract class ReqMaintenanceJob : Request, IReqSingle {
		/// <summary>
		/// An object to contain the "id" of the <see cref="MaintenanceJob"/>.
		/// </summary>
		public ParamId maintenanceJob { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.maintenanceJob?.id.ToString() ?? "";
	}
}