namespace Trakit.Objects {
	/// <summary>
	/// The name of folder where the message is stored.
	/// </summary>
	public enum MessageFolder : byte {
		/// <summary>
		/// The inbox is loaded quickly from memory, but messages regularly move to the archive.
		/// </summary>
		inbox,
		/// <summary>
		/// The archive contains all previous messages, but must be queried from disk for retrieval.
		/// </summary>
		archive,
	}
}