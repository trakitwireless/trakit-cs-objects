using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="user"/>.
	/// </summary>
	public class RespUserBatchDelete : Response {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="User"/>.
		/// </summary>
		public RespDeleted[] users;
	}
}