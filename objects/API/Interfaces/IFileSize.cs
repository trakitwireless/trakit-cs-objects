namespace trakit.objects {
	/// <summary>
	/// An interface for an object's size on a disk.
	/// </summary>
	public interface IFileSize {
		/// <summary>
		/// Size (in bytes) of the object on the HDD or SSD.
		/// </summary>
		ulong bytes { get; }
	}
}