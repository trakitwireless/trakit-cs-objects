namespace Trakit.Objects {
	/// <summary>
	/// A billing rule for assets
	/// </summary>
	public class BillableHostingRule : BillableHostingBase {
		/// <summary>
		/// The type of service being billed.
		/// </summary>
		public BillableHostingType service;
	}
}