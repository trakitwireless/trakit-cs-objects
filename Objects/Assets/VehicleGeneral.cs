namespace Trakit.Objects {
	/// <summary>
	/// Seldom changing details about a vehicle.
	/// </summary>
	public class VehicleGeneral : AssetGeneral {
		/// <summary>
		/// Manufacturer's unique identification number (Vehicle Identification Number).
		/// </summary>
		public string vin;
		/// <summary>
		/// The license plate.
		/// </summary>
		public string plate;
		/// <summary>
		/// Manufacturer's name.
		/// </summary>
		public string make;
		/// <summary>
		/// Manufacturer's model name/number.
		/// </summary>
		public string model;
		/// <summary>
		/// Year of manufacturing.
		/// </summary>
		public ushort year;
		/// <summary>
		/// Primary colour of the vehicle (given in 24bit hex; #RRGGBB)
		/// </summary>
		public string colour;
	}
}