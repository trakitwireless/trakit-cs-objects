using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// The types of subscriptions available using <see cref="subscribe"/>/<see cref="unsubscribe"/>.
	/// Each type has a different synchronization messages and objects.
	/// </summary>
	public class ReqSubscriptionMerge : Request {
		/// <summary>
		/// An object to contain the "id" key.
		/// </summary>
		/// <seealso cref="Company.id"/>
		public ParamId company { get; set; }
		/// <summary>
		/// The list of subscription types you want to receive.
		/// </summary>
		/// <seealso cref="SubscriptionType"/>
		public List<SubscriptionType> subscriptionTypes;
	}
}