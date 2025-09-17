namespace Trakit.Objects {
	/// <summary>
	/// The types of alerts used.
	/// </summary>
	public enum UserNotificationsMethod : byte {
		/// <summary>
		/// A separate message sent across the WebSocket.
		/// </summary>
		popup,
		/// <summary>
		/// A text message (SMS).
		/// </summary>
		sms,
		/// <summary>
		/// Carrier pigeon.
		/// </summary>
		email,
	}
}