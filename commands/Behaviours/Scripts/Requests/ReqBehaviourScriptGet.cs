using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="BehaviourScript"/>.
	/// </summary>
	public class ReqBehaviourScriptGet : ReqBehaviourScript, IReqIDeletable {
		/// <summary>
		/// When true, the command will also return a deleted <see cref="BehaviourScript"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}
}