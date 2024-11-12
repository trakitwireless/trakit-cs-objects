namespace trakit.objects {
	/// <summary>
	/// An interface for objects that can be marked as "enabled".
	/// "Enabled" objects remain in the system, but are inactive.
	/// </summary>
	public interface IEnabled {
		/// <summary>
		/// Marked as true for objects that have been deleted.
		/// </summary>
		bool enabled { get; }
	}
}