using System;

namespace Trakit.Objects {
	/// <summary>
	/// An image stored by the system.
	/// </summary>
	public class Picture : Component, IIdUlong, INamed, IBelongCompany, IFileSize, IDeletable {
		/// <summary>
		/// Unique identifier of this image.
		/// </summary>
		public ulong id { get; set; }
		/// <summary>
		/// The company to which this image belongs.
		/// </summary>
		/// <seealso cref="Company.id" />
		public ulong company { get; set; }
		/// <summary>
		/// The file name of this image.
		/// </summary>
		/// <override max-length="100" />
		public string name { get; set; }
		/// <summary>
		/// Notes about this image.
		/// </summary>
		public string notes { get; set; }
		/// <summary>
		/// The URL/path to find this image.
		/// </summary>
		/// <override max-length="200" />
		public string src { get; set; }
		/// <summary>
		/// Resolution defined in pixels.
		/// </summary>
		public Size size { get; set; }
		/// <summary>
		/// A list of focal points in the images like faces.
		/// </summary>
		public Square[] focals;
		/// <summary>
		/// The file-size on the disk.
		/// </summary>
		public ulong bytes { get; set; }
		/// <summary>
		/// A count of the times this image was used for something (asset, contact, task, etc).
		/// </summary>
		public uint uses;

		// IRequestable
		/// <summary>
		/// The <see cref="id"/> is the key.
		/// </summary>
		/// <returns></returns>
		public override string GetKey() => this.id.ToString();

		// IDeletable
		/// <summary>
		/// Indicates whether this object was deleted.
		/// </summary>
		public bool? deleted { get; set; }
		/// <summary>
		/// Timestamp from the action that deleted or suspended this object.
		/// </summary>
		public DateTime? since { get; set; }
	}
}