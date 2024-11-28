using System;
using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Allows a session <see cref="User"/> to change their own preferences.
	/// </summary>
	public class ReqSelfPreferences : Request {
		/// <summary>
		/// Preferred region/language for the UI and notifications.
		/// Valid formats use &lt;ISO 639-1&gt;&lt;dash&gt;&lt;ISO 3166-2&gt; such as "fr-CA" or "en-US".
		/// </summary>
		public string language;
		/// <summary>
		/// Your local <see cref="Timezone"/> used to calculate times.
		/// </summary>
		/// <seealso cref="Timezone.code" />
		public TimeZoneInfo timezone;
		/// <summary>
		/// List of <see cref="UserNotifications"/> preferences.
		/// Please note that active times cannot overlap.
		/// </summary>
		public List<UserNotifications> notify;
		/// <summary>
		/// Formatting help for dates, times, numbers.
		/// </summary>
		public Dictionary<string, string> formats;
		/// <summary>
		/// Preferred way of displaying ambiguous numbers in the context of measurements.
		/// </summary>
		public Dictionary<string, SystemsOfUnits?> measurements;
		/// <summary>
		/// Additional options which do not fit in with the formats or measurements preferences.
		/// If a value of null is given, the option is removed.  To keep the option, you can use a blank string.
		/// For convenience, if the value of an option is given as JSON (instead of a string), they are automatically serialized with no white-space.
		/// </summary>
		public Dictionary<string, string> options;
	}
}