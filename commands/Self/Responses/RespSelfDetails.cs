using System;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="User"/> or <see cref="Machine"/> of the current session.
	/// </summary>
	public class RespSelfDetails : Response {
		/// <summary>
		/// Your session identifier.
		/// </summary>
		public string ghostId;
		/// <summary>
		/// The timestamp of when this session expires.
		/// </summary>
		public DateTime? expiry;
		/// <summary>
		/// This session's <see cref="User"/> details (if the service is being used by a <see cref="User"/>).
		/// If this value is not present, then the session is not yet authenticated.
		/// </summary>
		public SelfUser user;
		/// <summary>
		/// This <see cref="Machine"/>'s details (if the service is being used by a <see cref="Machine"/>).
		/// If this value is not present, then the session is not a machine account.
		/// </summary>
		public SelfMachine machine;
		/// <summary>
		/// This <see cref="User"/>'s <see cref="CompanyPolicies.sessionPolicy"/>.
		/// </summary>
		public SessionPolicy sessionPolicy;
		/// <summary>
		/// This <see cref="User"/>'s <see cref="CompanyPolicies.passwordPolicy"/>.
		/// </summary>
		public PasswordPolicy passwordPolicy;
		/// <summary>
		/// The UTC date/time of the server hosting the connection.
		/// </summary>
		public DateTime serverTime;
	}
}