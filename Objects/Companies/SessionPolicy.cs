namespace Trakit.Objects {
	/// <summary>
	/// The session lifetime policy.
	/// </summary>
	public class SessionPolicy {
		/// <summary>
		/// The list of applications users are allowed to use to create sessions.
		/// </summary>
		public string[] applications;
		/// <summary>
		/// Restrict session creation to only the provided IPv4 ranges (using CIDR slash-notation).  Leave blank for Internet access.
		/// </summary>
		public string[] ipv4Ranges;
		/// <summary>
		/// Defines the behaviour of the system when a user creates multiple sessions.
		/// </summary>
		public SessionMultiUser multiUser;
		/// <summary>
		/// Defines whether a session should be automatically killed when the connection breaks.
		/// </summary>
		public bool idleAllowed;
		/// <summary>
		/// The lifetime duration of a session in minutes.
		/// </summary>
		public ushort expireTimeout;
		/// <summary>
		/// The maximum number of sessions allowed per user.
		/// </summary>
		public byte maxSessions;
	}
}