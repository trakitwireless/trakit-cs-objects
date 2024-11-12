namespace trakit.objects {
	/// <summary>
	/// An interface for objects that belong to a single billing profile.
	/// </summary>
	public interface IBelongBillingProfile {
		/// <summary>
		/// The <see cref="BillingProfile"/> to which this object belongs.
		/// </summary>
		ulong profile { get; }
	}
}