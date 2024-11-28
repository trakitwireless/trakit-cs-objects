using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Creates a new or updates an existing <see cref="ReportResult"/>.
	/// </summary>
	public class ReqReportResultMerge : Request, IReqSingle {
		/// <summary>
		/// Parameters given to create or update a <see cref="ReportResult"/>.
		/// </summary>
		public ParamReportResultMerge reportResult { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.reportResult?.id?.ToString() ?? "";
	}
}