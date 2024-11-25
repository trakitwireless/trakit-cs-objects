using System;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Container for a full session response.
	/// Used specifically to give session details.
	/// </summary>
	public class SessionDetails : SessionHandle {
		/// <summary>
		/// The (most recent) software being used by this <see cref="SessionDetails"/>.
		/// </summary>
		public string userAgent;
		/// <summary>
		/// The (most recent) IP address that used this <see cref="SessionDetails"/> to connect.
		/// </summary>
		/// <override format="ipv4" />
		public string ipAddress;
		/// <summary>
		/// The number of current-active WebSocket connections.
		/// </summary>
		public int sockets;
		/// <summary>
		/// This <see cref="SessionDetails"/>'s current state.
		/// </summary>
		public SessionStatus status;
		/// <summary>
		/// The timestamp from the moment this <see cref="SessionDetails"/> was created.
		/// </summary>
		public DateTime created;
		/// <summary>
		/// The name or path of the last command executed.
		/// </summary>
		public string lastCommand;
		/// <summary>
		/// A timestamp from the last command or call to the system.
		/// </summary>
		public DateTime lastActivity;

		/// <summary>
		/// Indicator that this <see cref="SessionDetails"/> is using at least one WebSocket connection.
		/// </summary>
		public bool active => this.sockets > 0;
	}
}