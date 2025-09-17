using System;

namespace Trakit.Objects {
	/// <summary>
	/// A discount rule for assets
	/// </summary>
	[Obsolete("Never implemented.")]
	public class BillableHostingDiscount : BillableHostingBase {
		/// <summary>
		/// The type of services being discounted.
		/// </summary>
		public BillableHostingType[] services;
		/// <summary>
		/// When true, the amount is used as a percentage value instead of a currency values.
		/// </summary>
		public bool percentage;
	}
}