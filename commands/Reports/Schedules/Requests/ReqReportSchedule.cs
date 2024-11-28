using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="reportSchedule"/> object.
	/// </summary>
	public abstract class ReqReportSchedule : Request, IReqSingle {
		/// <summary>
		/// An object to contain the "id" of the <see cref="ReportSchedule"/>.
		/// </summary>
		public ParamId reportSchedule { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.reportSchedule?.id.ToString() ?? "";
	}
}