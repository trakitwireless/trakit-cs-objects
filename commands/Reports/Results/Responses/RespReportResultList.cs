using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="reportResults"/>.
	/// </summary>
	public abstract class RespReportResultList : Response {
		/// <summary>
		/// The list of requested <see cref="ReportResult"/>s.
		/// </summary>
		public ReportResult[] reportResults;
	}

	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class RespReportResultListByCompany : RespReportResultList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public RespId company;
	}
}