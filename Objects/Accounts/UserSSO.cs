using System;

namespace Trakit.Objects {
	/// <summary>
	/// Single Sign-On authentication details for a user.
	/// </summary>
	public class UserSSO {
		/// <summary>
		/// Indicates whether SSO is enabled for the user.
		/// </summary>
		public bool enabled { get; set; }
		/// <summary>
		/// The identity provider used for SSO.
		/// </summary>
		public SSOIdentityProvider provider { get; set; }
		/// <summary>
		/// The last time the user authenticated using SSO.
		/// </summary>
		public DateTime? lastAuthentication { get; set; }
		/// <summary>
		/// External user ID from the identity provider.
		/// </summary>
		public string externalId { get; set; }
	}
}