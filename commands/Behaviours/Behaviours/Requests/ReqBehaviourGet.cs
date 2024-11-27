using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="Behaviour"/>.
	/// </summary>
	public class ReqBehaviourGet : ReqBehaviour, IReqIDeletable {
		/// <summary>
		/// When true, the command will also return a deleted <see cref="Behaviour"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}
}