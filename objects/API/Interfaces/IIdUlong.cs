namespace trakit.objects {
	/// <summary>
	/// An interface for objects with a ulong "id".
	/// </summary>
	public interface IIdUlong {
		/// <summary>
		/// Unique identifier of this object.
		/// </summary>
		ulong id { get; }
	}
}