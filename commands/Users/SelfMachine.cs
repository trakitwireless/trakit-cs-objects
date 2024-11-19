using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the details of the <see cref="Machine"/> requested.
	/// </summary>
	public class SelfMachine : Compound, IEnabled, IBelongCompany, IHavePreferences, IHavePermissions, IDeletable {
		/// <summary>
		/// 
		/// </summary>
		[JsonIgnore]
		protected override Component[] Pieces => new Component[] {
			this.General,
		};

		/// <summary>
		/// The unique idenifier this service account uses to access the system.
		/// </summary>
		/// <seealso cref="Asset.id" />
		public string key => this.General?.key
						?? throw new NullReferenceException("general");
		/// <summary>
		/// The company to which this service account belong.
		/// </summary>
		/// <seealso cref="Company.id" />
		public ulong company => this.General?.company
						?? throw new NullReferenceException("general");

		/// <summary>
		/// 
		/// </summary>
		[JsonIgnore]
		public Machine General { get; set; }
		/// <summary>
		/// Indicates whether system access is disable.
		/// </summary>
		public bool enabled {
			get => (this.General ?? throw new NullReferenceException("general")).enabled;
			set => (this.General ?? throw new NullReferenceException("general")).enabled = value;
		}
		/// <summary>
		/// Human friendly name for these credentials
		/// </summary>
		/// <override max-length="100" />
		public string nickname {
			get => (this.General ?? throw new NullReferenceException("general")).nickname;
			set => (this.General ?? throw new NullReferenceException("general")).nickname = value;
		}
		/// <summary>
		/// Notes about this machine.
		/// </summary>
		/// <override max-length="8000" />
		public string notes {
			get => (this.General ?? throw new NullReferenceException("general")).notes;
			set => (this.General ?? throw new NullReferenceException("general")).notes = value;
		}
		/// <summary>
		/// An optional timestamp that restricts this machine account from being used before the given date.
		/// </summary>
		public DateTime? notBefore {
			get => (this.General ?? throw new NullReferenceException("general")).notBefore;
			set => (this.General ?? throw new NullReferenceException("general")).notBefore = value;
		}
		/// <summary>
		/// An optional timestamp that restricts this machine account from being used after the given date.
		/// </summary>
		public DateTime? notAfter {
			get => (this.General ?? throw new NullReferenceException("general")).notAfter;
			set => (this.General ?? throw new NullReferenceException("general")).notAfter = value;
		}
		/// <summary>
		/// The service account's local timezone.
		/// </summary>
		/// <seealso cref="Timezone.code" />
		public Timezone timezone {
			get => (this.General ?? throw new NullReferenceException("general")).timezone;
			set => (this.General ?? throw new NullReferenceException("general")).timezone = value;
		}
		/// <summary>
		/// Preferred region/language for the UI and notifications.
		/// Valid formats use &lt;ISO 639-1&gt;&lt;dash&gt;&lt;ISO 3166-2&gt; such as "fr-CA" or "en-US".
		/// </summary>
		/// <override min-length="2" max-length="5" format="codified" />
		public string language {
			get => (this.General ?? throw new NullReferenceException("general")).language;
			set => (this.General ?? throw new NullReferenceException("general")).language = value;
		}
		/// <summary>
		/// The format strings defining the preferred way to display ambiguous values.
		/// </summary>
		/// <override>
		/// <keys format="codified" />
		/// <values max-length="20" format="datetimetemplate" />
		/// </override>
		public Dictionary<string, string> formats {
			get => (this.General ?? throw new NullReferenceException("general")).formats;
			set => (this.General ?? throw new NullReferenceException("general")).formats = value;
		}
		/// <summary>
		/// Preferred way of displaying ambiguous numbers in the context of measurements.
		/// </summary>
		/// <override>
		/// <keys format="codified" />
		/// </override>
		public Dictionary<string, SystemsOfUnits> measurements {
			get => (this.General ?? throw new NullReferenceException("general")).measurements;
			set => (this.General ?? throw new NullReferenceException("general")).measurements = value;
		}
		/// <summary>
		/// Additional options which do not fit in with the formats or measurements preferences.
		/// </summary>
		/// <override>
		/// <keys format="codified" />
		/// <values max-length="20" />
		/// </override>
		public Dictionary<string, string> options {
			get => (this.General ?? throw new NullReferenceException("general")).options;
			set => (this.General ?? throw new NullReferenceException("general")).options = value;
		}

		/// <summary>
		/// Permission rules which override the group rules.
		/// </summary>
		public Permission[] permissions {
			get => (this.General ?? throw new NullReferenceException("general")).permissions;
			set => (this.General ?? throw new NullReferenceException("general")).permissions = value;
		}
		/// <summary>
		/// A list of groups to which this machine account belongs.
		/// </summary>
		/// <seealso cref="UserGroup.id" />
		public UserGroup[] groups { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonIgnore]
		ulong[] IHavePermissions.groups => this.groups.Select(g => g.id).ToArray();

		/// <summary>
		/// List of system service URIs that this machine account is permitted to access.
		/// </summary>
		/// <override>
		/// <values type="System.String" max-length="254" format="url" />
		/// </override>
		public Uri[] services {
			get => (this.General ?? throw new NullReferenceException("general")).services;
			set => (this.General ?? throw new NullReferenceException("general")).services = value;
		}
		/// <summary>
		/// Optional list of your managed domains from which this machine account can be used.
		/// </summary>
		/// <override>
		/// <values type="System.String" max-length="254" format="url" />
		/// </override>
		public Uri[] referrers {
			get => (this.General ?? throw new NullReferenceException("general")).referrers;
			set => (this.General ?? throw new NullReferenceException("general")).referrers = value;
		}
		/// <summary>
		/// Restrict service access to only the provided IP ranges.
		/// Currently we only support IPv4 ranges using CIDR slash-notation.
		/// </summary>
		/// <override>
		/// <values max-length="19" format="ipv4" />
		/// </override>
		public string[] ipRanges {
			get => (this.General ?? throw new NullReferenceException("general")).ipRanges;
			set => (this.General ?? throw new NullReferenceException("general")).ipRanges = value;
		}
		/// <summary>
		/// When true, no access restrictions (<see cref="secret"/>, <see cref="referrers"/>, or <see cref="ipRanges"/>) are enforced.
		/// </summary>
		public bool insecure {
			get => (this.General ?? throw new NullReferenceException("general")).insecure;
			set => (this.General ?? throw new NullReferenceException("general")).insecure = value;
		}

		// IRequestable
		/// <summary>
		/// The <see cref="key"/> is the key (how about that).
		/// </summary>
		/// <returns></returns>
		public override string GetKey() => this.key;

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