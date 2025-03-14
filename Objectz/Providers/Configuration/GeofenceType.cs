using System;

namespace Trakit.Objects {

	/// <summary>
	/// An abstract class used as a base for all Geofence type classes.
	/// </summary>
	[Obsolete]
	public abstract class GeofenceType {
		/// <summary>
		/// The supported shape of geofence.
		/// </summary>
		public PlaceType type;
		/// <summary>
		/// The maximum number of unique geofences supported by the device.
		/// </summary>
		public uint maxGeofenceCount;
	}
}