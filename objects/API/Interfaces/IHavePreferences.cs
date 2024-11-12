using System.Collections.Generic;

namespace trakit.objects {
	/// <summary>
	/// This interface exists so that I can work with Machine and UserGeneral objects the same way.
	/// </summary>
	public interface IHavePreferences {
		/// <summary>
		/// The local timezone for this object.
		/// </summary>
		/// <seealso cref="Timezone.code" />
		Timezone timezone { get; }
		/// <summary>
		/// Preferred region/language for the UI and notifications.
		/// Valid formats use &lt;ISO 639-1&gt;&lt;dash&gt;&lt;ISO 3166-2&gt; such as "fr-CA" or "en-US".
		/// </summary>
		/// <override min-length="2" max-length="5" format="codified" />
		string language { get; }
		/// <summary>
		/// The format strings defining the preferred way to display ambiguous values.
		/// </summary>
		/// <override>
		/// <keys format="codified" />
		/// <values max-length="20" />
		/// </override>
		Dictionary<string, string> formats { get; }
		/// <summary>
		/// Preferred way of displaying ambiguous numbers in the context of measurements.
		/// </summary>
		/// <override>
		/// <keys format="codified" />
		/// </override>
		Dictionary<string, SystemsOfUnits> measurements { get; }
		/// <summary>
		/// Additional options which do not fit in with the formats or measurements preferences.
		/// </summary>
		/// <override>
		/// <keys format="codified" />
		/// <values max-length="20" />
		/// </override>
		Dictionary<string, string> options { get; }
	}
}