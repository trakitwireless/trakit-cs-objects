namespace Trakit.Objects {
	/// <summary>
	/// The server used for notification and conversational email messages sent and received by the system.
	/// </summary>
	public class NotificationServerEmail {
		/// <summary>
		/// The type of incoming protocol to use (IMAP or POP3).
		/// </summary>
		public string incomingType;
		/// <summary>
		/// The domain or IP address of the incoming email server.
		/// </summary>
		public string incomingAddress;
		/// <summary>
		/// The port number of the incoming email server.
		/// </summary>
		public ushort incomingPort;
		/// <summary>
		/// The username used to login to the incoming email server.
		/// </summary>
		public string incomingLogin;
		/// <summary>
		/// Is the incoming email server using a secure SSL/TLS connection (it should).
		/// </summary>
		public bool incomingSecure;
		/// <summary>
		/// IMAP message sequence number so only recent messages are retrieved.
		/// </summary>
		public uint incomingMessageNumber;
		/// <summary>
		/// The type of outgoing protocol to use (only SMTP).
		/// </summary>
		public string outgoingType;
		/// <summary>
		/// The domain or IP address of the outgoing email server.
		/// </summary>
		public string outgoingAddress;
		/// <summary>
		/// The port number of the outgoing email server.
		/// </summary>
		public ushort outgoingPort;
		/// <summary>
		/// The username used to login to the outgoing email server.
		/// </summary>
		public string outgoingLogin;
		/// <summary>
		/// Is the outgoing email server using a secure SSL/TLS connection (it should).
		/// </summary>
		public bool outgoingSecure;
		/// <summary>
		/// An optional field which can be set as the "sent from" and/or "reply-to" address.
		/// </summary>
		/// <override format="email" />
		public string outgoingReplyTo;
	}
}