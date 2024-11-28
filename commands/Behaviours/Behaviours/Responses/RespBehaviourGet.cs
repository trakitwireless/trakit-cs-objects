using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="behaviour"/>.
	/// </summary>
	public class RespBehaviourGet : Response {
		/// <summary>
		/// The requested <see cref="Behaviour"/>.
		/// </summary>
		public Behaviour behaviour;
	}
}