using System;

namespace Trakit.Objects {
	/// <summary>
	/// A geofence whose boundary is a "rectangle" defined by corner coordinates.
	/// </summary>
	[Obsolete]
	public class ProviderGeofenceRectangle : GeofenceType {
		/// <summary>
		/// The smallest possible diameter for this geofence.
		/// </summary>
		public int maxLength;
		/// <summary>
		/// The smallest possible diameter for this geofence.
		/// </summary>
		public int maxWidth;
	}
}