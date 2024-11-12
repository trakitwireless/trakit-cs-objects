using System.Collections.Generic;

namespace Trakit.Objects {
	/// <summary>
	/// The list of Contacts from this and other companies broken down by contact role.
	/// </summary>
	/// <override skip="true" />
	public class CompanyDirectory : Component, IIdUlong, IAmCompany {
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
		/// The list of Contacts from this and other companies broken down by contact role.
		/// </summary>
		/// <override>
		/// <values>
		/// <values>
		/// <seealso cref="Contact.id" />
		/// </values>
		/// </values>
		/// </override>
		public Dictionary<string, ulong[]> directory;

		// IRequestable
		/// <summary>
		/// The <see cref="id"/> is the key.
		/// </summary>
		/// <returns></returns>
		public override string getKey() => this.id.ToString();
	}
}