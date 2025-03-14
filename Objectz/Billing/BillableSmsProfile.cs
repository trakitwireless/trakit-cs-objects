namespace Trakit.Objects {
	/// <summary>
	/// Description of a tiered SMS messaging limit
	/// </summary>
	public class BillableSmsProfile {
		/// <summary>
		/// The maximum number of messages sent per cycle
		/// </summary>
		public uint limit;
		/// <summary>
		/// Cost per SMS message sent.
		/// Received messages are free.
		/// </summary>
		public double amount;
	}
}