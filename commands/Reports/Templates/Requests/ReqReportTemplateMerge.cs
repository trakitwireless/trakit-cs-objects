using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Creates a new or updates an existing <see cref="ReportTemplate"/>.
	/// </summary>
	public class ReqReportTemplateMerge : Request, IReqSingle {
		/// <summary>
		/// Parameters given to create or update a <see cref="ReportTemplate"/>.
		/// </summary>
		public ParamReportTemplateMerge reportTemplate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.reportTemplate?.id?.ToString() ?? "";
	}
}