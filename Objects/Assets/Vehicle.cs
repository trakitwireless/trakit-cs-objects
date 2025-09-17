using System;

namespace Trakit.Objects {
	/// <summary>
	/// The full details of a Vehicle, containing all the properties from the <see cref="VehicleGeneral"/> and <see cref="VehicleAdvanced"/> objects.
	/// </summary>
	public class Vehicle : Asset {
		/// <summary>
		/// General details about this vehicle.
		/// </summary>
		new public VehicleGeneral General {
			get => (VehicleGeneral)base.General;
			set => base.General = value;
		}
		/// <summary>
		/// Advanced details about this vehicle.
		/// </summary>
		new public VehicleAdvanced Advanced {
			get => (VehicleAdvanced)base.Advanced;
			set => base.Advanced = value;
		}

		/// <summary>
		/// Manufacturer's unique identification number (Vehicle Identification Number).
		/// </summary>
		public string vin {
			get => (this.General ?? throw new NullReferenceException("general")).vin;
			set => (this.General ?? throw new NullReferenceException("general")).vin = value;
		}
		/// <summary>
		/// The license plate.
		/// </summary>
		public string plate {
			get => (this.General ?? throw new NullReferenceException("general")).plate;
			set => (this.General ?? throw new NullReferenceException("general")).plate = value;
		}
		/// <summary>
		/// Manufacturer's name.
		/// </summary>
		public string make {
			get => (this.General ?? throw new NullReferenceException("general")).make;
			set => (this.General ?? throw new NullReferenceException("general")).make = value;
		}
		/// <summary>
		/// Manufacturer's model name/number.
		/// </summary>
		public string model {
			get => (this.General ?? throw new NullReferenceException("general")).model;
			set => (this.General ?? throw new NullReferenceException("general")).model = value;
		}
		/// <summary>
		/// Year of manufacturing.
		/// </summary>
		public ushort year {
			get => (this.General ?? throw new NullReferenceException("general")).year;
			set => (this.General ?? throw new NullReferenceException("general")).year = value;
		}
		/// <summary>
		/// Primary colour of the vehicle (given in 24bit hex; #RRGGBB)
		/// </summary>
		public string colour {
			get => (this.General ?? throw new NullReferenceException("general")).colour;
			set => (this.General ?? throw new NullReferenceException("general")).colour = value;
		}

		/// <summary>
		/// The cumulative duration that the vehicle's engine has been running (in decimal hours).
		/// </summary>
		public double engineHours {
			get => (this.Advanced ?? throw new NullReferenceException("advanced")).engineHours;
			set => (this.Advanced ?? throw new NullReferenceException("advanced")).engineHours = value;
		}
	}
}