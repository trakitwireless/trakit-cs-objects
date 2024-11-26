using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="userGroup"/>.
	/// </summary>
	public class RespUserGroupDelete : Response {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="UserGroup"/>.
		/// </summary>
		public RespDeleted userGroup;
	}
}