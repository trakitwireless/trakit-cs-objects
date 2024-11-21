using System;

namespace Trakit.Commands {
	/// <summary>
	/// Details of a command or session being throttled.
	/// </summary>
	public class ErrorDetailThrottled : ErrorDetail {
		/// <summary>
		/// The session identifier being throttled.
		/// </summary>
		public string ghostId;
		/// <summary>
		/// The <see cref="User"/> being throttled.
		/// </summary>
		public string login;
		/// <summary>
		/// The client IP address.
		/// </summary>
		public string ip;
		/// <summary>
		/// The name of the WebSocket command, or the RESTful route.
		/// </summary>
		public string command;
		/// <summary>
		/// How many times this command was invoked during the window.
		/// Alternatively, can be the maximum number of times this command can be invoked (like creating a session).
		/// </summary>
		public int count;
		/// <summary>
		/// The size of the window.
		/// If this throttled command has no window (ie; creating too many sessions) this value is null.
		/// </summary>
		public TimeSpan? timeout;
	}
}