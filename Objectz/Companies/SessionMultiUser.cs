namespace Trakit.Objects {
	/// <summary>
	/// Defines the behaviour of the system when a user creates multiple sessions.
	/// </summary>
	public enum SessionMultiUser : byte {
		/// <summary>
		/// Allow users to create multiple simultaneous sessions.
		/// </summary>
		allow,
		/// <summary>
		/// Deny users from creating new sessions if they already have an active session.
		/// </summary>
		deny,
		/// <summary>
		/// Allow users to create a new session, but automatically kill the previous session.
		/// </summary>
		replace,
	}
}