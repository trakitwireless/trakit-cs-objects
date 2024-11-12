namespace trakit.objects {
	/// <summary>
	/// An interface for objects that belong to a single asset.
	/// </summary>
	public interface IBelongAsset {
		/// <summary>
		/// The <see cref="Asset"/> to which this object belongs.
		/// </summary>
		ulong asset { get; }
	}
}