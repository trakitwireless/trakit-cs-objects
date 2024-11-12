using System;

namespace trakit.objects {
	/// <summary>
	/// GPS position information
	/// </summary>
	public class Position {
		/// <summary>Latitude</summary>
		public double? lat;
		/// <summary>Longitude</summary>
		public double? lng;
		/// <summary>Speed</summary>
		public double? speed;
		/// <summary>Direction of travel</summary>
		public ushort? bearing;
		/// <summary>Distance in meters from the sea level</summary>
		public double? altitude;
		/// <summary>Threshold in meters for the accuracy of a position</summary>
		public uint? accuracy;
		/// <summary>The Date/Time of the GPS reading</summary>
		public DateTime dts;
		/// <summary>A better description of the current road-segment</summary>
		public StreetAddress streetAddress;
		/// <summary>The posted speed limit for the road segment</summary>
		public double? speedLimit;
		/// <summary>Provider Identifier</summary>
		public string origin;
		/// <summary>The road segment description</summary>
		public string address => this.streetAddress?.ToString() ?? "";
	}
}