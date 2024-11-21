using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Parameters used to create or update an <see cref="Asset"/>.
	/// </summary>
	public class ParamAssetMerge : ParamMergeSubscribable {
		/// <summary>
		/// The unique identifier of the <see cref="Asset"/> you want to update.
		/// </summary>
		/// <override required="update" />
		public ulong? id;
		/// <summary>
		/// The identifier of the <see cref="Company"/> to which this <see cref="Asset"/> belongs.
		/// After creation, this value is read-only.
		/// </summary>
		/// <override required="create" />
		public ulong? company;
		/// <summary>
		/// The kind of <see cref="Asset"/> being created.
		/// After creation, this value is read-only.
		/// </summary>
		/// <override required="create" />
		public AssetType? kind;
		/// <summary>
		/// Name for the <see cref="Asset"/>.
		/// </summary>
		/// <override required="create" max-length="100" />
		public string name;
		/// <summary>
		/// Notes for the <see cref="Asset"/>.
		/// </summary>
		public string notes;
		/// <summary>
		/// The identifier of the <see cref="Icon"/> used to represent this <see cref="Asset"/> in the UI.
		/// </summary>
		/// <override required="create" />
		/// <seealso cref="Icon.id" />
		public ulong? icon;
		/// <summary>
		/// A list of <format id="codified"/>&amp;nbsp;<see cref="CompanyStyles.labels">label</see> names to categorize/organize this <see cref="Asset"/>.
		/// </summary>
		/// <override>
		/// <values format="codified">
		/// <seealso cref="LabelStyle.code" />
		/// </values>
		/// </override>
		public List<string> labels;
		/// <summary>
		/// Replaces the <see cref="Asset"/>'s status tags with the given list of <format id="codified"/> tags.
		/// </summary>
		public List<string> tags;
		/// <summary>
		/// Allows you to add, remove, and replace attributes.
		/// For each <see cref="AssetAttribute"/> in the attributes object,
		/// the value will be replaced on the <see cref="Asset"/>.
		/// If value is null, the attribute is removed from the <see cref="Asset"/>.
		/// If the key in the attributes object is different from the <format id="codified"/>(<see cref="AssetAttribute.name"/>)
		/// in the object, the attribute of the key is removed from the <see cref="Asset"/>, and one of the codified name is added to the <see cref="Asset"/>.
		/// If a new value or null is not provided for a current attribute, no change is made.
		/// </summary>
		public Dictionary<string, AssetAttribute?> attributes;
		/// <summary>
		/// The email address or phone number of this <see cref="Asset"/> when a <see cref="Person"/>'s <see cref="Contact"/> card is blank, or the <see cref="Provider"/>'s <see cref="ProviderGeneral.pnd">PND</see> is not installed.
		/// </summary>
		public string messagingAddress;
		/// <summary>
		/// The identifiers of <see cref="Picture"/>s of this <see cref="Asset"/>.
		/// </summary>
		/// <override>
		/// <values>
		/// <seealso cref="Picture.id" />
		/// </values>
		/// </override>
		public List<ulong> pictures;
		/// <summary>
		/// Name/value collections of custom fields used to refer to external systems.
		/// If the value is null, the references are removed from the <see cref="Asset"/>.
		/// </summary>
		public Dictionary<string, string> references;
		/// <summary>
		/// The contact card details for this <see cref="Asset"/>.
		/// Only applicable if <c>asset.kind</c> is <see cref="AssetType.person"/>.
		/// </summary>
		/// <override required="create (for person)" />
		public ulong? contact;
		/// <summary>
		/// The year this <see cref="Vehicle"/> or <see cref="Trailer"/> was built.
		/// Only applicable if <c>asset.kind</c> is <see cref="AssetType.vehicle"/> or <see cref="AssetType.trailer"/>.
		/// </summary>
		public ushort? year;
		/// <summary>
		/// The license plate of this <see cref="Vehicle"/> or <see cref="Trailer"/>.
		/// Only applicable if <c>asset.kind</c> is <see cref="AssetType.vehicle"/> or <see cref="AssetType.trailer"/>.
		/// </summary>
		public string plate;
		/// <summary>
		/// The manufacturer of this <see cref="Vehicle"/> or <see cref="Trailer"/>.
		/// Only applicable if <c>asset.kind</c> is <see cref="AssetType.vehicle"/> or <see cref="AssetType.trailer"/>.
		/// </summary>
		public string make;
		/// <summary>
		/// The model of this <see cref="Vehicle"/> or <see cref="Trailer"/>.
		/// Only applicable if <c>asset.kind</c> is <see cref="AssetType.vehicle"/> or <see cref="AssetType.trailer"/>.
		/// </summary>
		public string model;
		/// <summary>
		/// The pretty-pretty colour of this <see cref="Vehicle"/> or <see cref="Trailer"/>.
		/// Only applicable if <c>asset.kind</c> is <see cref="AssetType.vehicle"/> or <see cref="AssetType.trailer"/>.
		/// </summary>
		/// <override max-length="22" format="colour" />
		public string colour;
		/// <summary>
		/// The manufacturer's identification number of this <see cref="Trailer"/>.
		/// Only applicable if <c>asset.kind</c> is <see cref="AssetType.vehicle"/>.
		/// </summary>
		public string serial;
		/// <summary>
		/// The Vehicle Identification Number of this <see cref="Vehicle"/>.
		/// Only applicable if <c>asset.kind</c> is <see cref="AssetType.trailer"/>.
		/// </summary>
		public string vin;
		/// <summary>
		/// The distance travelled by this <see cref="Asset"/>.
		/// Can be a GPS odometer, OBD-II odometer, or other depending on scripts.
		/// </summary>
		public double? odometer;
		/// <summary>
		/// The number of hours the engine has been running for this <see cref="Vehicle"/>.
		/// Only applicable if <c>asset.kind</c> is <see cref="AssetType.vehicle"/>.
		/// </summary>
		public double? engineHours;
		/// <summary>
		/// A list of related asset identifiers like a driver for a <see cref="Vehicle"/>, or <see cref="Trailer"/> for a truck.
		/// </summary>
		/// <override>
		/// <values>
		/// <seealso cref="Asset.id" />
		/// </values>
		/// </override>
		public List<ulong> relationships;
	}
}