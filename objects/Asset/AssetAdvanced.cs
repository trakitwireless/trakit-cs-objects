using System.Collections.Generic;

namespace Trakit.Objects {
	/// <summary>
	/// Often changing details about a thing.
	/// </summary>
	public class AssetAdvanced : Component, IIdUlong, IBelongCompany {
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
		/// The things GPS coordinates including speed, bearing, and street information.
		/// </summary>
		public Position position;
		/// <summary>
		/// The cumulative distance travelled in kilometres.
		/// </summary>
		public double odometer;
		/// <summary>
		/// The codified status tag names.
		/// </summary>
		/// <override>
		/// <values format="codified">
		/// <seealso cref="LabelStyle.code" />
		/// </values>
		/// </override>
		public string[] tags;
		/// <summary>
		/// A list of attributes given to this asset by the connection device such as wiring state, VBus, etc.
		/// </summary>
		/// <override>
		/// <keys format="codified">
		/// <seealso cref="AssetAttribute.name" />
		/// </keys>
		/// </override>
		public Dictionary<string, AssetAttribute> attributes;
		/// <summary>
		/// The list of devices providing events for this asset.
		/// </summary>
		/// <override readonly="true">
		/// <values>
		/// <seealso cref="Provider.id" />
		/// </values>
		/// </override>
		public string[] providers;
		/// <summary>
		/// A list of assets related to this one; like a Person for a Vehicle (driver).
		/// </summary>
		/// <override>
		/// <values>
		/// <seealso cref="Asset.id" />
		/// </values>
		/// </override>
		public ulong[] relationships;
		/// <summary>
		/// The current state of this asset's interaction with known Places.
		/// </summary>
		/// <override>
		/// <keys>
		/// <seealso cref="Place.id" />
		/// </keys>
		/// </override>
		public Dictionary<ulong, AssetPlaceStatus> places;

		// IRequestable
		/// <summary>
		/// The <see cref="id"/> is the key.
		/// </summary>
		/// <returns></returns>
		public override string GetKey() => this.id.ToString();
	}
}