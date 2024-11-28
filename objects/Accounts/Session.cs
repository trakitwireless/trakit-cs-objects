using System;

namespace Trakit.Objects {
	/// <summary>
	/// Information about another <see cref="User"/>'s <see cref="Session"/>.
	/// </summary>
	public class Session : IBelongCompany {
		/// <summary>
		/// A "handle" identifying a resource.
		/// </summary>
		public string handle;
		/// <summary>
		/// Getter shortcut for the <see cref="User"/>'s <see cref="Company.id"/>.
		/// </summary>
		public ulong company { get; set; }
		/// <summary>
		/// <c>UserAgent</c> identification string
		/// </summary>
		public string userAgent { get; set; }
		/// <summary>
		/// The IP address the user last used to connect using this session.
		/// </summary>
		public string ipAddress { get; set; }
		/// <summary>
		/// The number of currently connected WebSocket clients.
		/// </summary>
		public int sockets;
		/// <summary>
		/// The <see cref="User"/> to which the <see cref="Session"/> belongs.
		/// </summary>
		/// <seealso cref="User.login" />
		public string login;
		/// <summary>
		/// This <see cref="Session"/>'s current state.
		/// </summary>
		public SessionStatus status;
		/// <summary>
		/// The timestamp from the moment this <see cref="Session"/> was created.
		/// </summary>
		public DateTime created;
		/// <summary>
		/// A timestamp for when the <see cref="RespSession"/> will expire.
		/// </summary>
		public DateTime expiry;
		/// <summary>
		/// The name or path of the last command executed.
		/// </summary>
		public string lastCommand;
		/// <summary>
		/// A timestamp from the last command or call to the system.
		/// </summary>
		public DateTime lastActivity;
		/// <summary>
		/// Indicator that this <see cref="Session"/> is using at least one WebSocket connection.
		/// </summary>
		public bool active => this.sockets > 0;
	}
}