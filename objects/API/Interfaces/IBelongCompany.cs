namespace trakit.objects {
	/// <summary>
	/// An interface for objects that belong to a single company.
	/// </summary>
	public interface IBelongCompany {
		/// <summary>
		/// The <see cref="Company"/> to which this object belongs.
		/// </summary>
		ulong company { get; }
	}
}