using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="hostingRule"/>.
	/// </summary>
	public class RespBillableHostingRuleBatchDelete : Response {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="BillableHostingRule"/>.
		/// </summary>
		public RespIdDeleted[] hostingRules;
	}
}