using System;
using System.Collections.Generic;

namespace Trakit.Objects {
	/// <summary>
	/// A service account that allowes for API access of system services.
	/// </summary>
	public class Machine : Component, IEnabled, IBelongCompany, IHavePreferences, IHavePermissions, IDeletable {
		/// <summary>
		/// The unique idenifier used to access the system.
		/// </summary>
		/// <override max-length="50" />
		public string key { get; set; }
		/// <summary>
		/// The company to which this user belongs.
		/// </summary>
		/// <seealso cref="Company.id" />
		public ulong company { get; set; }
		/// <summary>
		/// Indicates whether system access is disable.
		/// </summary>
		public bool enabled { get; set; }
		/// <summary>
		/// A token used to encode or validate requests.
		/// </summary>
		/// <override max-length="1000" />
		public string secret;
		/// <summary>
		/// Human friendly name for these credentials
		/// </summary>
		/// <override max-length="100" />
		public string nickname;
		/// <summary>
		/// Notes about this machine.
		/// </summary>
		/// <override max-length="8000" />
		public string notes;
		/// <summary>
		/// An optional timestamp that restricts this machine account from being used before the given date.
		/// </summary>
		public DateTime? notBefore;
		/// <summary>
		/// An optional timestamp that restricts this machine account from being used after the given date.
		/// </summary>
		public DateTime? notAfter;
		/// <summary>
		/// The service account's local timezone.
		/// </summary>
		/// <seealso cref="Timezone.code" />
		public Timezone timezone { get; set; }
		/// <summary>
		/// Preferred region/language for the UI and notifications.
		/// Valid formats use &lt;ISO 639-1&gt;&lt;dash&gt;&lt;ISO 3166-2&gt; such as "fr-CA" or "en-US".
		/// </summary>
		/// <override min-length="2" max-length="5" format="codified" />
		public string language { get; set; }
		/// <summary>
		/// The format strings defining the preferred way to display ambiguous values.
		/// </summary>
		/// <override>
		/// <keys format="codified" />
		/// <values max-length="20" format="datetimetemplate" />
		/// </override>
		public Dictionary<string, string> formats { get; set; }
		/// <summary>
		/// Preferred way of displaying ambiguous numbers in the context of measurements.
		/// </summary>
		/// <override>
		/// <keys format="codified" />
		/// </override>
		public Dictionary<string, SystemsOfUnits> measurements { get; set; }
		/// <summary>
		/// Additional options which do not fit in with the formats or measurements preferences.
		/// </summary>
		/// <override>
		/// <keys format="codified" />
		/// <values max-length="20" />
		/// </override>
		public Dictionary<string, string> options { get; set; }

		/// <summary>
		/// A list of groups to which this machine account belongs.
		/// </summary>
		/// <seealso cref="UserGroup.id" />
		public ulong[] groups { get; set; }
		/// <summary>
		/// Permission rules which override the group rules.
		/// </summary>
		public Permission[] permissions { get; set; }
		/// <summary>
		/// List of system service URIs that this machine account is permitted to access.
		/// </summary>
		/// <override>
		/// <values type="System.String" max-length="254" format="url" />
		/// </override>
		public Uri[] services;
		/// <summary>
		/// Optional list of your managed domains from which this machine account can be used.
		/// </summary>
		/// <override>
		/// <values type="System.String" max-length="254" format="url" />
		/// </override>
		public Uri[] referrers;
		/// <summary>
		/// Restrict service access to only the provided IP ranges.
		/// Currently we only support IPv4 ranges using CIDR slash-notation.
		/// </summary>
		/// <override>
		/// <values max-length="19" format="ipv4" />
		/// </override>
		public string[] ipRanges;
		/// <summary>
		/// When true, no access restrictions (<see cref="secret"/>, <see cref="referrers"/>, or <see cref="ipRanges"/>) are enforced.
		/// </summary>
		public bool insecure;

		// IRequestable
		/// <summary>
		/// The <see cref="key"/> is the key (how about that).
		/// </summary>
		/// <returns></returns>
		public override string getKey() => this.key;

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