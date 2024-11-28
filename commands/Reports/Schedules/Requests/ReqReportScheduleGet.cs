using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="ReportSchedule"/>.
	/// </summary>
	public class ReqReportScheduleGet : ReqReportSchedule, IReqIDeletable {
		/// <summary>
		/// When true, the command will also return a deleted <see cref="ReportSchedule"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}
}