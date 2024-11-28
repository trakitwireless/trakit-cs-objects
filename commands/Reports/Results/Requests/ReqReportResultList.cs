using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="reportResult"/>.
	/// </summary>
	public abstract class ReqReportResultList : Request, IReqIDeletable {
		/// <summary>
		/// When true, the command will also return  deleted <see cref="ReportResult"/>s.
		/// </summary>
		public bool includeDeleted { get; set; }
	}
	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class ReqReportResultListByCompany : ReqReportResultList, IReqListByCompany {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ParamId company { get; set; }
	}
}