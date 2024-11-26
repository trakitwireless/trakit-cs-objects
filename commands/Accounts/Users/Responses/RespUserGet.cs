using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="user"/>.
	/// </summary>
	public class RespUserGet : Response {
		/// <summary>
		/// The requested <see cref="User"/>.
		/// </summary>
		public User user;
	}
}