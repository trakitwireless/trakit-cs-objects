namespace trakit.objects {
	/// <summary>
	/// An interface for objects that have "pictures".
	/// </summary>
	/// <seealso cref="Picture.id" />
	public interface IPictured {
		/// <summary>
		/// A list of picture identifiers of this object.
		/// </summary>
		ulong[] pictures { get; }
	}
}