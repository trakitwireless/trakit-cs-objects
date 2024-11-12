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
		/// <override type="System.UInt32" />
		public int maxLength;
		/// <summary>
		/// The smallest possible diameter for this geofence.
		/// </summary>
		/// <override type="System.UInt32" />
		public int maxWidth;
	}
}