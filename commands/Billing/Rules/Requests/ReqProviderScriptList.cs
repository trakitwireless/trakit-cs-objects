using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="hostingRule"/>.
	/// </summary>
	public abstract class ReqBillableHostingRuleList : Request, IReqIDeletable {
		/// <summary>
		/// When true, the command will also return  deleted <see cref="BillableHostingRule"/>s.
		/// </summary>
		public bool includeDeleted { get; set; }
	}
	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class ReqBillableHostingRuleListByCompany : ReqBillableHostingRuleList, IReqListByCompany {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ParamId company { get; set; }
	}
}