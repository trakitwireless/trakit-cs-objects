using System;

namespace Trakit.Objects {
	/// <summary>
	/// Details about the lifetime of a <see cref="DispatchStep"/>.
	/// </summary>
	public class DispatchStepState {
		/// <summary>
		/// A timestamp from when the lifetime was updated.
		/// </summary>
		public DateTime updated;
		/// <summary>
		/// The coordinates from the <see cref="Asset"/> when the update happened.
		/// </summary>
		public LatLng latlng;
	}
}