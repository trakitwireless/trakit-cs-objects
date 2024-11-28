using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="reportTemplate"/>.
	/// </summary>
	public class RespReportTemplateGet : Response {
		/// <summary>
		/// The requested <see cref="ReportTemplate"/>.
		/// </summary>
		public ReportTemplate reportTemplate;
	}
}