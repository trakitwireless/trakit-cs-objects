namespace Trakit.Objects {
	/// <summary>
	/// Defines how User passwords expire.
	/// </summary>
	public enum PasswordExpiryMode : byte {
		/// <summary>
		/// Passwords never expire.
		/// </summary>
		never,
		/// <summary>
		/// Passwords expire after a defined number of days.
		/// </summary>
		days,
		/// <summary>
		/// Passwords expire after a defined number of successful logins.
		/// </summary>
		sessions,
	}
}