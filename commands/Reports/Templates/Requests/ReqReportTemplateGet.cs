using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="ReportTemplate"/>.
	/// </summary>
	public class ReqReportTemplateGet : ReqReportTemplate, IReqIDeletable {
		/// <summary>
		/// When true, the command will also return a deleted <see cref="ReportTemplate"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}
}