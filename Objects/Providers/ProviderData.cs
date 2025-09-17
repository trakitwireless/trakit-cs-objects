using System;

namespace Trakit.Objects {
	/// <summary>
	/// A fragment of data given by a device.
	/// </summary>
	public struct ProviderData {
		/// <summary>
		/// The value of the data given like true, 17.3, "asdf", etc...
		/// </summary>
		public object value;
		/// <summary>
		/// Date/time stamp from when the device recorded (or reported) the data.
		/// </summary>
		public DateTime dts;
		/// <summary>
		/// The relevant unit for the data provided like Km/h, degrees, volts, RPM, etc...
		/// </summary>
		public string unit;
	}
}