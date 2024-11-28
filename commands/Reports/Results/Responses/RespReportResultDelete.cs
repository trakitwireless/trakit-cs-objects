using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="reportResult"/>.
	/// </summary>
	public class RespReportResultDelete : Response {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="ReportResult"/>.
		/// </summary>
		public RespIdDeleted reportResult;
	}
}