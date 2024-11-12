namespace trakit.objects {
	/// <summary>
	/// An interface for objects that have a "name" and "notes".
	/// </summary>
	public interface INamed {
		/// <summary>
		/// This thing's name.
		/// </summary>
		string name { get; }
		/// <summary>
		/// This thing's notes.
		/// </summary>
		string notes { get; }
	}
}