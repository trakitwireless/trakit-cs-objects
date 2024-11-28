using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="BillableHostingRule"/>.
	/// </summary>
	public class ReqBillableHostingRuleGet : ReqBillableHostingRule, IReqIDeletable {
		/// <summary>
		/// When true, the command will also return a deleted <see cref="BillableHostingRule"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}
}