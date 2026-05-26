namespace Trakit.Objects {
	/// <summary>
	/// Supported SSO Identity Providers.
	/// </summary>
	public enum SSOIdentityProvider : byte {
		/// <summary>
		/// Google Identity Provider.
		/// </summary>
		google,
		/// <summary>
		/// Apple Identity Provider.
		/// </summary>
		apple,
		/// <summary>
		/// Facebook Identity Provider.
		/// </summary>
		facebook,
		/// <summary>
		/// X Identity Provider, formerly known as Twitter.
		/// </summary>
		twitter,
		/// <summary>
		/// Microsoft Identity Provider.
		/// </summary>
		microsoft,
	}
}