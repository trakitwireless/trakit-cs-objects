using System.Collections.Generic;

namespace Trakit.Objects {
	/// <summary>
	/// The colours and styles used by this company to tag and label Assets, Places, and other things.
	/// </summary>
	public class CompanyStyles : Component, IIdUlong, IAmCompany {
		/// <summary>
		/// Unique identifier of the Company.
		/// </summary>
		/// <seealso cref="Company.id" />
		public ulong id { get; set; }
		/// <summary>
		/// The unique identifier of this company's parent organization.
		/// </summary>
		/// <seealso cref="Company.id" />
		public ulong parent { get; set; }
		/// <summary>
		/// The styles for labels added to Assets, Places, and other things.
		/// </summary>
		public Dictionary<string, LabelStyle> labels;
		/// <summary>
		/// The styles for status tags added to Assets.
		/// </summary>
		public Dictionary<string, LabelStyle> tags;

		// IRequestable
		/// <summary>
		/// The <see cref="id"/> is the key.
		/// </summary>
		/// <returns></returns>
		public override string GetKey() => this.id.ToString();
	}
}