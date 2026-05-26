using System.Collections.Generic;

namespace Trakit.Objects {
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
		string language { get; }
		/// <summary>
		/// The format strings defining the preferred way to display ambiguous values.
		/// </summary>
		Dictionary<string, string> formats { get; }
		/// <summary>
		/// Preferred way of displaying ambiguous numbers in the context of measurements.
		/// </summary>
		Dictionary<string, SystemsOfUnits> measurements { get; }
	}
}