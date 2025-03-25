using System.Collections.Generic;

namespace Trakit.Objects {
	/// <summary>
	/// Definition for load-balanced outbound SMS numbers for the White-labelling profile.
	/// </summary>
	public class NotificationServerSms {
		/// <summary>
		/// A per-number/per-day limit on the amount of Notifications sent.
		/// </summary>
		public ushort notifyLimit;
		/// <summary>
		/// All phone numbers listed by the country (using two-digit ISO 3166-1 alpha-2 country codes) they each serve.
		/// </summary>
		/// <override>
		/// <keys length="2" />
		/// <values>
		/// <values format="phone" />
		/// </values>
		/// </override>
		public Dictionary<string, ulong[]> phoneNumbers;
	}
}