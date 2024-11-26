using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="user"/>.
	/// </summary>
	public class RespUserDelete : Response {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="User"/>.
		/// </summary>
		public RespDeleted user;
	}
}