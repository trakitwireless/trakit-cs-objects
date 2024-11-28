using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="reportTemplate"/>.
	/// </summary>
	public class RespReportTemplateBatchDelete : Response {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="ReportTemplate"/>.
		/// </summary>
		public RespIdDeleted[] reportTemplates;
	}
}