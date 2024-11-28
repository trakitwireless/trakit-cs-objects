using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="reportSchedule"/>.
	/// </summary>
	public class RespReportScheduleGet : Response {
		/// <summary>
		/// The requested <see cref="ReportSchedule"/>.
		/// </summary>
		public ReportSchedule reportSchedule;
	}
}