namespace Trakit.Commands {
	/// <summary>
	/// Gets the list of current subscriptions for your current session.
	/// </summary>
	public class RespSubscriptionList : Response {
		/// <summary>
		/// The list of your current subscription types.
		/// </summary>
		public Subscription[] subscriptions;
	}
}