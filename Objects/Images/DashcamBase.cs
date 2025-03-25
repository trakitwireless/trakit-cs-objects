namespace Trakit.Objects {
	/// <summary>
	/// A base class for Dashcam meta-data.
	/// </summary>
	public abstract class DashcamBase : IRequestable, IFileSize {
		/// <summary>
		/// Number bytes in the dashcam media file.
		/// </summary>
		public ulong bytes { get; set; }
		/// <summary>
		/// Resolution defined in pixels.
		/// </summary>
		public Size size;
		/// <summary>
		/// Unique identifier of the provider that sent the data.
		/// </summary>
		/// <seealso cref="Provider.id" />
		public string provider;
		/// <summary>
		/// Unique identifier of the company of the provider.
		/// </summary>
		/// <seealso cref="Company.id" />
		public ulong company;
		/// <summary>
		/// Unique identifier of the asset tied to the provider at the time.
		/// </summary>
		/// <seealso cref="Asset.id" />
		public ulong? asset;
		/// <summary>
		/// Number assigned to the camera that took the image/video.
		/// </summary>
		public byte camera;
		/// <summary>
		/// Latitude of the start of the resource.
		/// </summary>
		public double latitude;
		/// <summary>
		/// Longitude of the start of the resource.
		/// </summary>
		public double longitude;
		/// <summary>
		/// Speed of the start of the resource.
		/// </summary>
		public double speed;
		/// <summary>
		/// Heading of the start of the resource.
		/// </summary>
		public double heading;
		/// <summary>
		/// Altitude of the start of the resource.
		/// </summary>
		public double altitude;

		// IRequestable
		/// <summary>
		/// For dashcams, this is either a unique identifier, or a combination of the <see cref="asset"/>, <see cref="provider"/>, and <see cref="camera"/> values.
		/// </summary>
		/// <returns>A string unique for this type of object.</returns>
		public abstract string GetKey();
	}
}