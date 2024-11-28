using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="reportResult"/> object.
	/// </summary>
	public abstract class ReqReportResult : Request, IReqSingle {
		/// <summary>
		/// An object to contain the "id" of the <see cref="ReportResult"/>.
		/// </summary>
		public ParamId reportResult { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.reportResult?.id.ToString() ?? "";
	}
}