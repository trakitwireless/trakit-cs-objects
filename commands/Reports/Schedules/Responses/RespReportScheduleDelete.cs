using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="reportSchedule"/>.
	/// </summary>
	public class RespReportScheduleDelete : Response {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="ReportSchedule"/>.
		/// </summary>
		public RespIdDeleted reportSchedule;
	}
}