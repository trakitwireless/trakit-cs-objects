namespace Trakit.Objects {
	/// <summary>
	/// The priority of the alert.
	/// </summary>
	public enum AlertPriority : byte {
		/// <summary>
		/// Sends when no other alerts are pending in the queue.
		/// </summary>
		low,
		/// <summary>
		/// Sends in when there are no high priority alerts in the queue.
		/// </summary>
		normal,
		/// <summary>
		/// Sends before low and normal priority alerts.
		/// </summary>
		high,
	}
}