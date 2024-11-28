using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="hostingRules"/>.
	/// </summary>
	public abstract class RespBillableHostingRuleList : Response {
		/// <summary>
		/// The list of requested <see cref="BillableHostingRule"/>s.
		/// </summary>
		public BillableHostingRule[] hostingRules;
	}

	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class RespBillableHostingRuleListByCompany : RespBillableHostingRuleList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public RespId company;
	}
}