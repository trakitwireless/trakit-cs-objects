using System;

namespace Trakit.Objects {
	/// <summary>
	/// A live snapshot a dashcam-enabled provider or asset.
	/// </summary>
	public class DashcamLive : DashcamBase {
		/// <summary>
		/// The type of data being stored.
		/// </summary>
		public readonly DashcamMediaType kind = DashcamMediaType.image;
		/// <summary>
		/// Timestamp of this live camera image.
		/// </summary>
		public DateTime dts;

		// IRequestable
		/// <summary>
		/// A combination of the asset, provider, and camera number.
		/// </summary>
		/// <returns></returns>
		public override string GetKey() => (this.asset ?? ulong.MinValue)
									+ "-" + this.provider
									+ "-" + this.camera;
	}
}