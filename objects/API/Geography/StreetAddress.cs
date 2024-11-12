namespace trakit.objects {
	/// <summary>
	/// A road segment description
	/// </summary>
	public class StreetAddress {
		/// <summary>
		/// House number.
		/// </summary>
		public string number;
		/// <summary>
		/// Full street name.
		/// </summary>
		public string street;
		/// <summary>
		/// City name.
		/// </summary>
		public string city;
		/// <summary>
		/// Region name.
		/// </summary>
		public string region;
		/// <summary>
		/// Province or state code.
		/// Codes should be a value from ISO 3166-2.
		/// </summary>
		/// <override length="2" />
		public string province;
		/// <summary>
		/// Country code.
		/// Codes should be a value from ISO 3166-1 alpha-2.
		/// </summary>
		/// <override length="2" />
		public string country;
		/// <summary>
		/// Postal or zip code.
		/// </summary>
		public string postal;
		/// <summary>
		/// Indicates that there is a toll for the current road segment.
		/// </summary>
		public bool isToll;
	}
}