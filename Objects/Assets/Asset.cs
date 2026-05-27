using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Trakit.Objects {
	/// <summary>
	/// The full details of an Asset, containing all the properties from the <see cref="AssetGeneral"/> and <see cref="AssetAdvanced"/> objects.
	/// </summary>
	public class Asset : Compound, IIdUlong, INamed, IIconic, IBelongCompany, ILabelled, IPictured, ISuspendable, IDeletable {
		/// <summary>
		/// 
		/// </summary>
		[JsonIgnore]
		protected override Component[] Pieces => new Component[] {
			this.General,
			this.Advanced,
			this.dispatch,
		};

		/// <summary>
		/// Unique identifier of this asset.
		/// </summary>
		/// <seealso cref="Asset.id" />
		public ulong id => this.General?.id
						?? this.Advanced?.id
						?? this.dispatch?.id
						?? throw new NullReferenceException("general");
		/// <summary>
		/// The company to which this asset belongs.
		/// </summary>
		/// <seealso cref="Company.id" />
		public ulong company => this.General?.company
							?? this.Advanced?.company
							?? this.dispatch?.company
							?? throw new NullReferenceException("general");
		/// <summary>
		/// Type of asset.
		/// </summary>
		public AssetType kind => this.General?.kind
							?? throw new NullReferenceException("general");

		/// <summary>
		/// 
		/// </summary>
		[JsonIgnore]
		public AssetGeneral General { get; set; }
		/// <summary>
		/// This thing's name.
		/// </summary>
		public string name {
			get => (this.General ?? throw new NullReferenceException("general")).name;
			set => (this.General ?? throw new NullReferenceException("general")).name = value;
		}
		/// <summary>
		/// Notes about it.
		/// </summary>
		public string notes {
			get => (this.General ?? throw new NullReferenceException("general")).notes;
			set => (this.General ?? throw new NullReferenceException("general")).notes = value;
		}
		/// <summary>
		/// The icon that represents this asset on the map and in lists.
		/// </summary>
		/// <seealso cref="Icon.id" />
		public ulong icon {
			get => (this.General ?? throw new NullReferenceException("general")).icon;
			set => (this.General ?? throw new NullReferenceException("general")).icon = value;
		}
		/// <summary>
		/// Codified label names.
		/// </summary>
		public string[] labels {
			get => (this.General ?? throw new NullReferenceException("general")).labels;
			set => (this.General ?? throw new NullReferenceException("general")).labels = value;
		}
		/// <summary>
		/// A list of photos of this thing.
		/// </summary>
		public ulong[] pictures {
			get => (this.General ?? throw new NullReferenceException("general")).pictures;
			set => (this.General ?? throw new NullReferenceException("general")).pictures = value;
		}
		/// <summary>
		/// The fall-back address which is used to send Messages if the asset is a Person and has no Contact phone or email.
		/// </summary>
		public string messagingAddress {
			get => (this.General ?? throw new NullReferenceException("general")).messagingAddress;
			set => (this.General ?? throw new NullReferenceException("general")).messagingAddress = value;
		}
		/// <summary>
		/// Name/value collections of custom fields used to refer to external systems.
		/// </summary>
		public Dictionary<string, string> references {
			get => (this.General ?? throw new NullReferenceException("general")).references;
			set => (this.General ?? throw new NullReferenceException("general")).references = value;
		}

		#region Person
		/// <summary>
		/// A reference to their Company's Contact information.
		/// </summary>
		/// <seealso cref="Contact.id" />
		public ulong? contact {
			get => (this.General ?? throw new NullReferenceException("general")).contact;
			set => (this.General ?? throw new NullReferenceException("general")).contact = value;
		}
		#endregion Person
		#region Vehicle
		/// <summary>
		/// Manufacturer's unique identification number (Vehicle Identification Number).
		/// </summary>
		public string vin {
			get => (this.General ?? throw new NullReferenceException("general")).vin;
			set => (this.General ?? throw new NullReferenceException("general")).vin = value;
		}
		/// <summary>
		/// The cumulative duration that the vehicle's engine has been running (in decimal hours).
		/// </summary>
		public double? engineHours {
			get => (this.Advanced ?? throw new NullReferenceException("advanced")).engineHours;
			set => (this.Advanced ?? throw new NullReferenceException("advanced")).engineHours = value;
		}
		#endregion Vehicle
		#region Trailer
		/// <summary>
		/// Manufacturer's unique identification number for this trailer.
		/// </summary>
		public string serial {
			get => (this.General ?? throw new NullReferenceException("general")).serial;
			set => (this.General ?? throw new NullReferenceException("general")).serial = value;
		}
		#endregion Vehicle
		#region Vehicle and Trailer
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
		public ushort? year {
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
		#endregion Vehicle and Trailer

		/// <summary>
		/// 
		/// </summary>
		[JsonIgnore]
		public AssetAdvanced Advanced { get; set; }
		/// <summary>
		/// The things GPS coordinates including speed, bearing, and street information.
		/// </summary>
		public Position position {
			get => (this.Advanced ?? throw new NullReferenceException("advanced")).position;
			set => (this.Advanced ?? throw new NullReferenceException("advanced")).position = value;
		}
		/// <summary>
		/// The cumulative distance travelled in kilometres.
		/// </summary>
		public double odometer {
			get => (this.Advanced ?? throw new NullReferenceException("advanced")).odometer;
			set => (this.Advanced ?? throw new NullReferenceException("advanced")).odometer = value;
		}
		/// <summary>
		/// The codified status tag names.
		/// </summary>
		public string[] tags {
			get => (this.Advanced ?? throw new NullReferenceException("advanced")).tags;
			set => (this.Advanced ?? throw new NullReferenceException("advanced")).tags = value;
		}
		/// <summary>
		/// A list of attributes given to this asset by the connection device such as wiring state, VBus, etc.
		/// </summary>
		public Dictionary<string, AssetAttribute> attributes {
			get => (this.Advanced ?? throw new NullReferenceException("advanced")).attributes;
			set => (this.Advanced ?? throw new NullReferenceException("advanced")).attributes = value;
		}
		/// <summary>
		/// The list of devices providing events for this asset.
		/// </summary>
		public string[] providers {
			get => (this.Advanced ?? throw new NullReferenceException("advanced")).providers;
			set => (this.Advanced ?? throw new NullReferenceException("advanced")).providers = value;
		}
		/// <summary>
		/// A list of assets related to this one; like a Person for a Vehicle (driver).
		/// </summary>
		public ulong[] relationships {
			get => (this.Advanced ?? throw new NullReferenceException("advanced")).relationships;
			set => (this.Advanced ?? throw new NullReferenceException("advanced")).relationships = value;
		}
		/// <summary>
		/// The current state of this asset's interaction with known Places.
		/// </summary>
		public Dictionary<ulong, AssetPlaceStatus> places {
			get => (this.Advanced ?? throw new NullReferenceException("advanced")).places;
			set => (this.Advanced ?? throw new NullReferenceException("advanced")).places = value;
		}

		/// <summary>
		/// 
		/// </summary>
		public AssetDispatch dispatch { get; set; }

		// IRequestable
		/// <summary>
		/// The <see cref="id"/> is the key.
		/// </summary>
		/// <returns></returns>
		public override string GetKey() => this.id.ToString();

		// ISuspendable and IDeletable
		/// <summary>
		/// Indicates whether this object was deleted.
		/// </summary>
		public bool? deleted => (this.General ?? throw new NullReferenceException("general")).deleted;
		/// <summary>
		/// Indicates whether this object is suspended from event processing.
		/// </summary>
		public bool? suspended => (this.General ?? throw new NullReferenceException("general")).suspended;
		/// <summary>
		/// Timestamp from the action that deleted or suspended this object.
		/// </summary>
		public DateTime? since => (this.General ?? throw new NullReferenceException("general")).since;
	}
}