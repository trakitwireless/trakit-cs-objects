using System;

namespace Trakit.Objects {
	/// <summary>
	/// A simple status for each place an Asset visits.
	/// </summary>
	public class AssetPlaceStatus {
		/// <summary>
		/// The kind of interaction.
		/// </summary>
		public AssetPlaceStatusType kind;
		/// <summary>
		/// The date/time stamp for when the Asset first began interacting with the Place.
		/// </summary>
		public DateTime enter;
		/// <summary>
		/// The most recent date/time stamp for the interaction.
		/// </summary>
		public DateTime latest;
	}
}