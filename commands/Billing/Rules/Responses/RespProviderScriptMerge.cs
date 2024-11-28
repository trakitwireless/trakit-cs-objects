namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="hostingRule"/>.
	/// </summary>
	public class RespBillableHostingRuleMerge : Response {
		/// <summary>
		/// An object which contains the <c>id</c> and <c>company</c> keys when there is no error.
		/// </summary>
		public RespIdCompany hostingRule;
	}
}