using System;

namespace Trakit.Objects {
	/// <summary>
	/// A geofence defined by a centre coordinate and a threshold value to indicate the boundary around that point.
	/// </summary>
	/// <override skip="false" name="" />
	[Obsolete]
	public class ProviderGeofenceCircular : GeofenceType {
		/// <summary>
		/// The smallest possible radius for this geofence.
		/// </summary>
		public uint minRadius;
		/// <summary>
		/// The largest possible radius for this geofence.
		/// </summary>
		public uint maxRadius;
	}
}