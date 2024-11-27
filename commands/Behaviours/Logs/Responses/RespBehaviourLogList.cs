using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="behaviourLogs"/>.
	/// </summary>
	public abstract class RespBehaviourLogList : Response {
		/// <summary>
		/// The list of requested <see cref="BehaviourLog"/>s.
		/// </summary>
		public BehaviourLog[] behaviourLogs;
	}

	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class RespBehaviourLogListByCompany : RespBehaviourLogList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public RespId company;
	}
}