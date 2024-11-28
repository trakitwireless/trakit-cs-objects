using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="reportSchedules"/>.
	/// </summary>
	public abstract class RespReportScheduleList : Response {
		/// <summary>
		/// The list of requested <see cref="ReportSchedule"/>s.
		/// </summary>
		public ReportSchedule[] reportSchedules;
	}

	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class RespReportScheduleListByCompany : RespReportScheduleList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public RespId company;
	}
}