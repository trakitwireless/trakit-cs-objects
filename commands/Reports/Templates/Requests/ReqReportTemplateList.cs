using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="reportTemplate"/>.
	/// </summary>
	public abstract class ReqReportTemplateList : Request, IReqIDeletable {
		/// <summary>
		/// When true, the command will also return  deleted <see cref="ReportTemplate"/>s.
		/// </summary>
		public bool includeDeleted { get; set; }
	}
	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class ReqReportTemplateListByCompany : ReqReportTemplateList, IReqListByCompany {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ParamId company { get; set; }
	}
}