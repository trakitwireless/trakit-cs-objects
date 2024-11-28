using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="hostingRule"/>.
	/// </summary>
	public class RespBillableHostingRuleGet : Response {
		/// <summary>
		/// The requested <see cref="BillableHostingRule"/>.
		/// </summary>
		public BillableHostingRule hostingRule;
	}
}