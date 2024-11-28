using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="behaviourScript"/>.
	/// </summary>
	public class RespBehaviourScriptDelete : Response {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="BehaviourScript"/>.
		/// </summary>
		public RespIdDeleted behaviourScript;
	}
}