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
			this.general,
			this.advanced,
			this.dispatch,
		};

		/// <summary>
		/// Unique identifier of this asset.
		/// </summary>
		/// <seealso cref="Asset.id" />
		public ulong id => this.general?.id
						?? this.advanced?.id
						?? this.dispatch?.id
						?? throw new NullReferenceException("general");
		/// <summary>
		/// The company to which this asset belongs.
		/// </summary>
		/// <seealso cref="Company.id" />
		public ulong company => this.general?.company
							?? this.advanced?.company
							?? this.dispatch?.company
							?? throw new NullReferenceException("general");
		/// <summary>
		/// Type of asset.
		/// </summary>
		public AssetType kind => this.general?.kind
							?? throw new NullReferenceException("general");

		/// <summary>
		/// 
		/// </summary>
		[JsonIgnore]
		public AssetGeneral general { get; set; }
		/// <summary>
		/// This thing's name.
		/// </summary>
		/// <override max-length="100" />
		public string name {
			get => (this.general ?? throw new NullReferenceException("general")).name;
			set => (this.general ?? throw new NullReferenceException("general")).name = value;
		}
		/// <summary>
		/// Notes about it.
		/// </summary>
		public string notes {
			get => (this.general ?? throw new NullReferenceException("general")).notes;
			set => (this.general ?? throw new NullReferenceException("general")).notes = value;
		}
		/// <summary>
		/// The icon that represents this asset on the map and in lists.
		/// </summary>
		/// <seealso cref="Icon.id" />
		public ulong icon {
			get => (this.general ?? throw new NullReferenceException("general")).icon;
			set => (this.general ?? throw new NullReferenceException("general")).icon = value;
		}
		/// <summary>
		/// Codified label names.
		/// </summary>
		/// <override>
		/// <values format="codified">
		/// <seealso cref="LabelStyle.code" />
		/// </values>
		/// </override>
		public string[] labels {
			get => (this.general ?? throw new NullReferenceException("general")).labels;
			set => (this.general ?? throw new NullReferenceException("general")).labels = value;
		}
		/// <summary>
		/// A list of photos of this thing.
		/// </summary>
		/// <override>
		/// <values>
		/// <seealso cref="Picture.id" />
		/// </values>
		/// </override>
		public ulong[] pictures {
			get => (this.general ?? throw new NullReferenceException("general")).pictures;
			set => (this.general ?? throw new NullReferenceException("general")).pictures = value;
		}
		/// <summary>
		/// The fall-back address which is used to send Messages if the asset is a Person and has no Contact phone or email.
		/// </summary>
		/// <override max-length="254" />
		public string messagingAddress {
			get => (this.general ?? throw new NullReferenceException("general")).messagingAddress;
			set => (this.general ?? throw new NullReferenceException("general")).messagingAddress = value;
		}
		/// <summary>
		/// Name/value collections of custom fields used to refer to external systems.
		/// </summary>
		/// <override max-count="10">
		/// <keys max-length="20" />
		/// <values max-length="100" />
		/// </override>
		public Dictionary<string, string> references {
			get => (this.general ?? throw new NullReferenceException("general")).references;
			set => (this.general ?? throw new NullReferenceException("general")).references = value;
		}

		/// <summary>
		/// 
		/// </summary>
		[JsonIgnore]
		public AssetAdvanced advanced { get; set; }
		/// <summary>
		/// The things GPS coordinates including speed, bearing, and street information.
		/// </summary>
		public Position position {
			get => (this.advanced ?? throw new NullReferenceException("advanced")).position;
			set => (this.advanced ?? throw new NullReferenceException("advanced")).position = value;
		}
		/// <summary>
		/// The cumulative distance travelled in kilometres.
		/// </summary>
		public double odometer {
			get => (this.advanced ?? throw new NullReferenceException("advanced")).odometer;
			set => (this.advanced ?? throw new NullReferenceException("advanced")).odometer = value;
		}
		/// <summary>
		/// The codified status tag names.
		/// </summary>
		/// <override>
		/// <values format="codified">
		/// <seealso cref="LabelStyle.code" />
		/// </values>
		/// </override>
		public string[] tags {
			get => (this.advanced ?? throw new NullReferenceException("advanced")).tags;
			set => (this.advanced ?? throw new NullReferenceException("advanced")).tags = value;
		}
		/// <summary>
		/// A list of attributes given to this asset by the connection device such as wiring state, VBus, etc.
		/// </summary>
		/// <override>
		/// <keys format="codified">
		/// <seealso cref="AssetAttribute.name" />
		/// </keys>
		/// </override>
		public Dictionary<string, AssetAttribute> attributes {
			get => (this.advanced ?? throw new NullReferenceException("advanced")).attributes;
			set => (this.advanced ?? throw new NullReferenceException("advanced")).attributes = value;
		}
		/// <summary>
		/// The list of devices providing events for this asset.
		/// </summary>
		/// <override readonly="true">
		/// <values>
		/// <seealso cref="Provider.id" />
		/// </values>
		/// </override>
		public string[] providers {
			get => (this.advanced ?? throw new NullReferenceException("advanced")).providers;
			set => (this.advanced ?? throw new NullReferenceException("advanced")).providers = value;
		}
		/// <summary>
		/// A list of assets related to this one; like a Person for a Vehicle (driver).
		/// </summary>
		/// <override>
		/// <values>
		/// <seealso cref="Asset.id" />
		/// </values>
		/// </override>
		public ulong[] relationships {
			get => (this.advanced ?? throw new NullReferenceException("advanced")).relationships;
			set => (this.advanced ?? throw new NullReferenceException("advanced")).relationships = value;
		}
		/// <summary>
		/// The current state of this asset's interaction with known Places.
		/// </summary>
		/// <override>
		/// <keys>
		/// <seealso cref="Place.id" />
		/// </keys>
		/// </override>
		public Dictionary<ulong, AssetPlaceStatus> places {
			get => (this.advanced ?? throw new NullReferenceException("advanced")).places;
			set => (this.advanced ?? throw new NullReferenceException("advanced")).places = value;
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
		public bool? deleted => (this.general ?? throw new NullReferenceException("general")).deleted;
		/// <summary>
		/// Indicates whether this object is suspended from event processing.
		/// </summary>
		public bool? suspended => (this.general ?? throw new NullReferenceException("general")).suspended;
		/// <summary>
		/// Timestamp from the action that deleted or suspended this object.
		/// </summary>
		public DateTime? since => (this.general ?? throw new NullReferenceException("general")).since;
	}
}