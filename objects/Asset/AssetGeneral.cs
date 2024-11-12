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
		/// <override max-length="100" />
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
		/// <override>
		/// <values format="codified">
		/// <seealso cref="LabelStyle.code" />
		/// </values>
		/// </override>
		public string[] labels { get; set; }
		/// <summary>
		/// A list of photos of this thing.
		/// </summary>
		/// <override>
		/// <values>
		/// <seealso cref="Picture.id" />
		/// </values>
		/// </override>
		public ulong[] pictures { get; set; }
		/// <summary>
		/// The fall-back address which is used to send Messages if the asset is a Person and has no Contact phone or email.
		/// </summary>
		/// <override max-length="254" />
		public string messagingAddress;
		/// <summary>
		/// Name/value collections of custom fields used to refer to external systems.
		/// </summary>
		/// <override max-count="10">
		/// <keys max-length="20" />
		/// <values max-length="100" />
		/// </override>
		public Dictionary<string, string> references;

		// IRequestable
		/// <summary>
		/// The <see cref="id"/> is the key.
		/// </summary>
		/// <returns></returns>
		public override string getKey() => this.id.ToString();

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