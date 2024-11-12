using System;

namespace Trakit.Objects {
	/// <summary>
	/// An image or video received from a dashcam-enabled provider or asset.
	/// </summary>
	public class DashcamData : DashcamBase {
		/// <summary>
		/// Unique identifier of this resource.
		/// </summary>
		public Guid guid;
		/// <summary>
		/// The type of data being stored.
		/// </summary>
		public DashcamDataType kind;
		/// <summary>
		/// For <see cref="DashcamDataType.video"/> media files, this indicates the frames-per-second.
		/// </summary>
		public float? fps;
		/// <summary>
		/// Timestamp of when this resource started.
		/// For <see cref="DashcamDataType.image"/> media files, the start and end are the same.
		/// </summary>
		public DateTime start;
		/// <summary>
		/// Timestamp of when this resource ended.
		/// For <see cref="DashcamDataType.image"/> media files, the start and end are the same.
		/// </summary>
		public DateTime end;
		/// <summary>
		/// For <see cref="DashcamDataType.video"/> media files, the duration of the video clip.
		/// </summary>
		public TimeSpan duration => this.end - this.start;
		/// <summary>
		/// The reason why we're saving this image/video. Or the event name that triggered it.
		/// </summary>
		public string eventName;

		// IRequestable
		/// <summary>
		/// The <see cref="guid"/> is the key.
		/// </summary>
		/// <returns></returns>
		public override string GetKey() => this.guid.ToString();
	}
}