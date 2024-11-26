using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="User"/> of the current session.
	/// </summary>
	public class RespSessionGet : Response {
		/// <summary>
		/// The requested <see cref="Session"/> details.
		/// </summary>
		public Session session;
	}
}