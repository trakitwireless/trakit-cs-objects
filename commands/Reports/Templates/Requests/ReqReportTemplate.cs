using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="reportTemplate"/> object.
	/// </summary>
	public abstract class ReqReportTemplate : Request, IReqSingle {
		/// <summary>
		/// An object to contain the "id" of the <see cref="ReportTemplate"/>.
		/// </summary>
		public ParamId reportTemplate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.reportTemplate?.id.ToString() ?? "";
	}
}