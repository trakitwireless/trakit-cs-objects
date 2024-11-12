using System;
using System.Collections.Generic;

namespace Trakit.Objects {
	/// <summary>
	/// Contact information.
	/// </summary>
	public class Contact : Component, IIdUlong, INamed, IBelongCompany, IPictured, IDeletable {
		/// <summary>
		/// Unique identifier of this contact.
		/// </summary>
		public ulong id { get; set; }
		/// <summary>
		/// The company to which this contact belongs
		/// </summary>
		/// <seealso cref="Company.id" />
		public ulong company { get; set; }
		/// <summary>
		/// The person's name
		/// </summary>
		/// <override max-length="100" />
		public string name { get; set; }
		/// <summary>
		/// Notes about this person.
		/// </summary>
		public string notes { get; set; }
		/// <summary>
		/// A collection of other names this person might go by.
		/// Use the object key like a name identifier.
		/// Example keys: Initials, Nickname, Maiden Name, etc.
		/// </summary>
		/// <override>
		/// <values max-length="254" />
		/// </override>
		public Dictionary<string, string> otherNames;
		/// <summary>
		/// Email addresses.
		/// Use the object key like a name of the address.
		/// Example keys: Home, Work, Support, Old, etc.
		/// </summary>
		/// <override>
		/// <values max-length="254" format="email" />
		/// </override>
		public Dictionary<string, string> emails;
		/// <summary>
		/// Phone numbers.
		/// Use the object key like a name of the phone number.
		/// Example keys: Mobile, Fax, Home, Office, etc.
		/// </summary>
		/// <override>
		/// <values format="phone" />
		/// </override>
		public Dictionary<string, ulong> phones;
		/// <summary>
		/// Mailing addresses.
		/// Use the object key like a name of the address.
		/// Example keys: Home, Work, Park, etc.
		/// </summary>
		public Dictionary<string, string> addresses;
		/// <summary>
		/// Websites and other online resources.
		/// Use the object key like a name of the address.
		/// Example keys: Downloads, Support, FTP, etc.
		/// </summary>
		/// <override>
		/// <values type="System.String" max-length="254" format="url" />
		/// </override>
		public Dictionary<string, Uri> urls;
		/// <summary>
		/// Date information.
		/// Use the object key like a name of the date.
		/// Example keys: Birthday, Started Date, Retired On, etc.
		/// </summary>
		public Dictionary<string, DateTime> dates;
		/// <summary>
		/// Uncategorized information.
		/// Use the object keys and values however you'd like.
		/// </summary>
		public Dictionary<string, string> options;
		/// <summary>
		/// A list of roles they play in the Company.
		/// </summary>
		/// <override format="codified" />
		public string[] roles;
		/// <summary>
		/// Pictures of this Contact.
		/// </summary>
		/// <override>
		/// <values>
		/// <seealso cref="Picture.id" />
		/// </values>
		/// </override>
		public ulong[] pictures { get; set; }

		// IRequestable
		/// <summary>
		/// The <see cref="id"/> is the key.
		/// </summary>
		/// <returns></returns>
		public override string getKey() => this.id.ToString();

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