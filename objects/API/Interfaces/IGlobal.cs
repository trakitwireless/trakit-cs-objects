namespace trakit.objects {
	/// <summary>
	/// An interface for objects that can be marked as "global".
	/// "Global" objects can be listed in child companies.
	/// </summary>
	public interface IGlobal : IBelongCompany {
		/// <summary>
		/// Indicates whether this icon is available to child companies.
		/// </summary>
		bool global { get; }
	}
}