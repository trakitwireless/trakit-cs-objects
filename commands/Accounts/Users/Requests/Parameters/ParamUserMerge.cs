using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Parameters used to create or update an <see cref="User"/>.
	/// </summary>
	public class ParamUserMerge : ParamMergeSubscribable {
		/// <summary>
		/// The unique identifier of the <see cref="User"/> you want to update.
		/// </summary>
		public string login;
		/// <summary>
		/// The company to which this <see cref="User"/> belongs.
		/// After creation, this value is read-only.
		/// </summary>
		public ulong? company;
		/// <summary>
		/// Human friendly name for these credentials
		/// </summary>
		public string nickname;
		/// <summary>
		/// This <see cref="User"/>'s password.
		/// </summary>
		[JsonIgnore]
		public string password;
		/// <summary>
		/// Indicated whether the credentials have expired according to the company's policy.
		/// </summary>
		public bool? passwordExpired;
		/// <summary>
		/// Indicates whether system access is disable.
		/// </summary>
		public bool? enabled;
		/// <summary>
		/// Contact information for this <see cref="User"/>.
		/// </summary>
		/// <seealso cref="Contact.id" />
		public ulong? contact;
		/// <summary>
		/// The <see cref="User"/>'s local timezone.
		/// </summary>
		/// <seealso cref="Timezone.code" />
		public TimeZoneInfo timezone;
		/// <summary>
		/// Preferred region/language for the UI and notifications.
		/// Valid formats use &lt;ISO 639-1&gt;&lt;dash&gt;&lt;ISO 3166-2&gt; such as "fr-CA" or "en-US".
		/// </summary>
		public string language;
		/// <summary>
		/// The format strings defining the preferred way to display ambiguous values.
		/// </summary>
		public Dictionary<string, string> formats;
		/// <summary>
		/// Preferred way of displaying ambiguous numbers in the context of measurements.
		/// </summary>
		public Dictionary<string, SystemsOfUnits?> measurements;
		/// <summary>
		/// Additional options which do not fit in with the formats or measurements preferences.
		/// </summary>
		public Dictionary<string, string> options;
		/// <summary>
		/// Definition of how and when to send alerts to the <see cref="User"/>.
		/// </summary>
		public List<UserNotifications> notify;
		/// <summary>
		/// A list of <see cref="UserGroup"/>s to which this <see cref="User"/> is a member.
		/// </summary>
		public List<ulong> groups;
		/// <summary>
		/// Individual permission rules which override the <see cref="UserGroup"/> rules.
		/// </summary>
		public List<ParamPermission> permissions;
	}
}