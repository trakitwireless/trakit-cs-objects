using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="hostingRule"/>.
	/// </summary>
	public class RespBillableHostingRuleDelete : Response {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="BillableHostingRule"/>.
		/// </summary>
		public RespIdDeleted hostingRule;
	}
}