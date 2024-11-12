using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// The types of subscriptions available using <see cref="TrakitSocket.subscribe"/>/<see cref="TrakitSocket.unsubscribe"/>.
	/// Each type has a different synchronization messages and objects.
	/// </summary>
	public class RespSubscription : Response {
		/// <summary>
		/// An object which contains only one key "id" when there is no error.
		/// The "id" key is the unique identifier of the company to which the array of objects relate.
		/// </summary>
		/// <seealso cref="Company.id"/>
		public RespId company;
		/// <summary>
		/// Subscription types added/removed (or were not applicable) to your socket's subscription list.
		/// </summary>
		public SubscriptionType[] merged;
		/// <summary>
		/// Subscription types not added to your socket due to insufficient permissions.
		/// </summary>
		public SubscriptionType[] denied;
		/// <summary>
		/// A returned list of nonsense you sent to my beautiful service.
		/// </summary>
		public string[] invalid;
	}
}