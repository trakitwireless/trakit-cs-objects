using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Trakit.Objects {
	/// <summary>
	/// State flags for this user.
	/// </summary>
	public class UserState : Component, IBelongCompany {
		/// <summary>
		/// The unique public email address used to access the system.
		/// </summary>
		/// <seealso cref="User.login" />
		public string login { get; set; }
		/// <summary>
		/// The company to which this user belongs.
		/// </summary>
		/// <seealso cref="Company.id" />
		public ulong company { get; set; }
		/// <summary>
		/// Additional options which do not fit in with the formats or measurements preferences.
		/// </summary>
		[DataMember]
		public Dictionary<string, string> options { get; set; }

		// IRequestable
		/// <summary>
		/// The <see cref="login"/> is the key.
		/// </summary>
		/// <returns></returns>
		public override string GetKey() => this.login;
	}
}