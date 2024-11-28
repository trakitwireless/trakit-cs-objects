using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="formResult"/>.
	/// </summary>
	public class RespFormResultDelete : Response {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="FormResult"/>.
		/// </summary>
		public RespIdDeleted formResult;
	}
}