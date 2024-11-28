using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="reportResult"/>.
	/// </summary>
	public class RespReportResultGet : Response {
		/// <summary>
		/// The requested <see cref="ReportResult"/>.
		/// </summary>
		public ReportResult reportResult;
	}
}