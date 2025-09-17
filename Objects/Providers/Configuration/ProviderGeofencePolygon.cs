using System;

namespace Trakit.Objects {
	/// <summary>
	/// A geofence whose boundary is defined by a non-overlapping series of coordinates.
	/// </summary>
	[Obsolete]
	public class ProviderGeofencePolygon : GeofenceType {
		/// <summary>
		/// The maximum number of vertices supported by the device.
		/// </summary>
		public uint maxVertices;
	}
}