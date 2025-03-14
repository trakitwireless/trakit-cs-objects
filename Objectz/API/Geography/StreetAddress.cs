using System.Collections.Generic;

namespace Trakit.Objects {
	/// <summary>
	/// A road segment description.
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

		/// <summary>
		/// Returns a text representation of this address.
		/// </summary>
		/// <remarks>
		/// Returned strings cannot be converted back into StreetAddress objects, so don't use this for deserialization.
		/// </remarks>
		/// <returns></returns>
		public override string ToString() {
			var address = new List<string>();
			if (!string.IsNullOrWhiteSpace(this.street)) address.Add((!string.IsNullOrWhiteSpace(this.number) ? this.number + " " : "") + this.street);
			if (!string.IsNullOrWhiteSpace(this.city)) address.Add(this.city);
			if (!string.IsNullOrWhiteSpace(this.region)) address.Add(this.region);
			if (!string.IsNullOrWhiteSpace(this.province)) address.Add(this.province);
			if (!string.IsNullOrWhiteSpace(this.country)) address.Add(this.country);
			if (!string.IsNullOrWhiteSpace(this.postal)) address.Add(this.postal);
			return string.Join(", ", address);
		}
	}
}