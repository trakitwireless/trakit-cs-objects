using System;

namespace Trakit.Objects {
	/// <summary>
	/// A coordinate on the globe
	/// </summary>
	public class LatLng : IEquatable<LatLng> {
		/// <summary>
		/// Let's consider the zero-zero coordinates to be invalid.
		/// </summary>
		public static LatLng INVALID => new LatLng(0, 0);

		/// <summary>
		/// Latitude
		/// </summary>
		public readonly double lat;
		/// <summary>
		/// Longitude
		/// </summary>
		public readonly double lng;

		public LatLng(double lat, double lng) {
			this.lat = Geography.NormalizeLatitude(lat);
			this.lng = Geography.NormalizeLongitude(lng);
		}
		//public override bool Equals(object obj) => obj is LatLng other && this.Equals(other);

		/// <summary>
		/// True when a <see cref="PlaceType.polygon"/> or <see cref="PlaceType.rectangle"/> shape has enough coordinates given.
		/// </summary>
		/// <param name="other"></param>
		/// <returns></returns>
		public bool Equals(LatLng other) => other?.IsValid() == this.IsValid()
									&& other?.lat == this.lat
									&& other?.lng == this.lng;

		/// <summary>
		/// True when a <see cref="PlaceType.radial"/> radius is within the allowed size range.
		/// </summary>
		/// <returns></returns>
		public bool IsValid() => Geography.NotNaN(this.lat) != 0
							&& Geography.NotNaN(this.lng) != 0;
	}
}