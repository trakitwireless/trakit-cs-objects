namespace Trakit.Objects {
	/// <summary>
	/// The type of dashcam data being stored.
	/// </summary>
	public enum DashcamDataType : byte {
		/// <summary>
		/// Unknown or other.
		/// </summary>
		unknown,
		/// <summary>
		/// Image
		/// </summary>
		image,
		/// <summary>
		/// Video
		/// </summary>
		video,
	}
}