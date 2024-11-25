using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="User"/> or <see cref="Machine"/> of the current session.
	/// </summary>
	public class RespSessionDelete : Response {
		/// <summary>
		/// An object which contains the <see cref="SessionDetails"/>' handle, related <see cref="User.login"/>, and owning <see cref="User.company"/> id.
		/// </summary>
		public SessionHandle session;
	}
}