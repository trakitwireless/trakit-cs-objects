using System;
using System.Collections.Generic;

namespace Trakit.Objects {
	/// <summary>
	/// Seldom changing details about a thing.
	/// </summary>
	public class AssetGeneral : Component, IIdUlong, INamed, IIconic, IBelongCompany, ILabelled, IPictured, ISuspendable, IDeletable {
		/// <summary>
		/// Unique identifier of this asset.
		/// </summary>
		/// <seealso cref="Asset.id" />
		public ulong id { get; set; }
		/// <summary>
		/// The company to which this asset belongs.
		/// </summary>
		/// <seealso cref="Company.id" />
		public ulong company { get; set; }
		/// <summary>
		/// Type of asset.
		/// </summary>
		public AssetType kind { get; set; }
		/// <summary>
		/// This thing's name.
		/// </summary>
		public string name { get; set; }
		/// <summary>
		/// The icon that represents this asset on the map and in lists.
		/// </summary>
		/// <seealso cref="Icon.id" />
		public ulong icon { get; set; }
		/// <summary>
		/// Notes about it.
		/// </summary>
		public string notes { get; set; }
		/// <summary>
		/// Codified label names.
		/// </summary>
		public string[] labels { get; set; }
		/// <summary>
		/// A list of photos of this thing.
		/// </summary>
		public ulong[] pictures { get; set; }
		/// <summary>
		/// The fall-back address which is used to send Messages if the asset is a Person and has no Contact phone or email.
		/// </summary>
		public string messagingAddress;
		/// <summary>
		/// Name/value collections of custom fields used to refer to external systems.
		/// </summary>
		public Dictionary<string, string> references;

		#region Person
		/// <summary>
		/// A reference to their Company's Contact information.
		/// </summary>
		/// <seealso cref="Contact.id" />
		public ulong? contact;
		#endregion Person
		#region Vehicle
		/// <summary>
		/// Manufacturer's unique identification number (Vehicle Identification Number).
		/// </summary>
		public string vin;
		#endregion Vehicle
		#region Trailer
		/// <summary>
		/// Manufacturer's unique identification number for this trailer.
		/// </summary>
		public string serial;
		#endregion Trailer
		#region Vehicle and Trailer
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
		public ushort? year;
		/// <summary>
		/// Primary colour of the vehicle (given in 24bit hex; #RRGGBB)
		/// </summary>
		public string colour;
		#endregion Vehicle and Trailer

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
		public bool? deleted { get; set; }
		/// <summary>
		/// Indicates whether this object is suspended from event processing.
		/// </summary>
		public bool? suspended { get; set; }
		/// <summary>
		/// Timestamp from the action that deleted or suspended this object.
		/// </summary>
		public DateTime? since { get; set; }
	}
}