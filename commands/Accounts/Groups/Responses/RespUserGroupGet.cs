using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="userGroup"/>.
	/// </summary>
	public class RespUserGroupGet : Response {
		/// <summary>
		/// The requested <see cref="UserGroup"/>.
		/// </summary>
		public UserGroup userGroup;
	}
}