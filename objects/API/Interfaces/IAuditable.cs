using System;

namespace trakit.objects {
	/// <summary>
	/// For auditable objects, a record of who and what mad the changes.
	/// </summary>
	public interface IAuditable {
		/// <summary>
		/// Details about the change to an object.
		/// </summary>
		IAuditableUpdated updated { get; }
		/// <summary>
		/// When the was change procesed.
		/// </summary>
		DateTime processedUtc { get; }
	}
	/// <summary>
	/// This class used in conjunction with the <see cref="version"/> member help with synchronization.
	/// </summary>
	public sealed class IAuditableUpdated {
		/// <summary>
		/// The <see cref="User.login"/> or <see cref="Machine.key"/> when the object is updated,
		/// or <see cref="Service.UserAgent"/> if a service updates the object itself.
		/// </summary>
		/// <seealso cref="User.login" />
		public string by;
		/// <summary>
		/// A <see cref="Service.UserAgent"/> that handled the update.
		/// </summary>
		public string from;
		/// <summary>
		/// Timestamp from when the change was made.
		/// </summary>
		public DateTime dts;
	}
}