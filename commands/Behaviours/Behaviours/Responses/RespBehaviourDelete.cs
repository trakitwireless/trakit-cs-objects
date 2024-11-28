using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="behaviour"/>.
	/// </summary>
	public class RespBehaviourDelete : Response {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="Behaviour"/>.
		/// </summary>
		public RespIdDeleted behaviour;
	}
}