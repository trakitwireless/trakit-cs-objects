using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="icon"/>.
	/// </summary>
	public class RespIconDelete : Response {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="Icon"/>.
		/// </summary>
		public RespIdDeleted icon;
	}
}