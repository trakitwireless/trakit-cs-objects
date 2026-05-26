using System.Collections.Generic;

namespace Trakit.Objects {
	/// <summary>
	/// Authentication details for a user, including MFA and SSO.
	/// </summary>
	public class UserAuthentication : Component, IBelongCompany {
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
		/// Indicated whether the credentials have expired according to the company's policy.
		/// </summary>
		public bool passwordExpired;
		/// <summary>
		/// Multi-factor authentication details for the user.
		/// </summary>
		public List<UserMFA> mfa { get; set; }
		/// <summary>
		/// Single Sign-On details for the user.
		/// </summary>
		public UserSSO sso { get; set; }

		// IRequestable
		/// <summary>
		/// The <see cref="login"/> is the key.
		/// </summary>
		/// <returns></returns>
		public override string GetKey() => this.login;
	}
}