namespace Trakit.Objects {
	/// <summary>
	/// The type of repeating cycle used for generating bills.
	/// </summary>
	public enum BillingCycle : byte {
		/// <summary>
		/// Once a month
		/// </summary>
		monthly,
		/// <summary>
		/// Every three months
		/// </summary>
		quarterly,
		/// <summary>
		/// Once per year
		/// </summary>
		annually,
	}
}