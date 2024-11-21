using System;

namespace Trakit.Commands {
	/// <summary>
	/// The response for a logout operation which is always successful.
	/// </summary>
	public class RespSelfLogout : Response {
		/// <summary>
		/// Your old, no longer valid, session identifier.
		/// </summary>
		public string ghostId;
		/// <summary>
		/// The timestamp from when your session expired.
		/// </summary>
		public DateTime? expiry;
	}
}