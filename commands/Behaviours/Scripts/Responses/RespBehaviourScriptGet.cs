using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="behaviourScript"/>.
	/// </summary>
	public class RespBehaviourScriptGet : Response {
		/// <summary>
		/// The requested <see cref="BehaviourScript"/>.
		/// </summary>
		public BehaviourScript behaviourScript;
	}
}