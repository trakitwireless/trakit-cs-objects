using System;

namespace Trakit.Objects {
	/// <summary>
	/// A visual representation of a thing on a map or in a list.
	/// </summary>
	public class Icon : Component, IIdUlong, INamed, IBelongCompany, IGlobal, IDeletable {
		/// <summary>
		/// Unique identifier of this icon.
		/// </summary>
		public ulong id { get; set; }
		/// <summary>
		/// The company to which this icon belongs.
		/// </summary>
		/// <seealso cref="Company.id" />
		public ulong company { get; set; }

		/// <summary>
		/// A noun to describe the type of thing represented.  Like Truck, Car, Trailer, Hot-Air Balloon, etc...
		/// </summary>
		/// <override max-length="100" />
		public string category;
		/// <summary>
		/// A specific adjective to describe the thing.  Like Blue, Red, Empty, Full, etc...
		/// </summary>
		/// <override max-length="100" />
		public string name { get; set; }
		/// <summary>
		/// Notes.
		/// </summary>
		public string notes { get; set; }
		/// <summary>
		/// Indicates whether this icon is available to child companies.
		/// </summary>
		public bool global { get; set; }
		/// <summary>
		/// A list of things that this icon can be used to represent.  Like asset, place, user, etc...
		/// </summary>
		public string[] usage;
		/// <summary>
		/// Definition for the name bubble above the icon on a map.
		/// </summary>
		public IconLabel label;
		/// <summary>
		/// Where the notification will appear for a mapped icon.
		/// Such as the number of dispatches an asset is working on, or the number of dispatches at a place.
		/// </summary>
		public IconLabel badge;
		/// <summary>
		/// The images used to show the detail of this icon.
		/// </summary>
		public IconGlyph[] glyphs;

		// IRequestable
		/// <summary>
		/// The <see cref="id"/> is the key.
		/// </summary>
		/// <returns></returns>
		public override string GetKey() => this.id.ToString();

		// IDeletable
		/// <summary>
		/// Indicates whether this object was deleted.
		/// </summary>
		public bool? deleted { get; set; }
		/// <summary>
		/// Timestamp from the action that deleted or suspended this object.
		/// </summary>
		public DateTime? since { get; set; }
	}
}