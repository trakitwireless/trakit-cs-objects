using System;

namespace Trakit.Objects {
	/// <summary>
	/// The full details of a Trailer, containing all the properties from the <see cref="TrailerGeneral"/> and <see cref="AssetAdvanced"/> objects.
	/// </summary>
	public class Trailer : Asset {
		/// <summary>
		/// General details about this trailer.
		/// </summary>
		new public TrailerGeneral General {
			get => (TrailerGeneral)base.General;
			set => base.General = value;
		}

		/// <summary>
		/// Manufacturer's unique identification number for this trailer.
		/// </summary>
		public string vin {
			get => (this.General ?? throw new NullReferenceException("general")).serial;
			set => (this.General ?? throw new NullReferenceException("general")).serial = value;
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
	}
}