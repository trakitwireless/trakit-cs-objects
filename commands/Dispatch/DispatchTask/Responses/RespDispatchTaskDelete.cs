using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="dispatchTask"/>.
	/// </summary>
	public class RespDispatchTaskDelete : Response {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="DispatchTask"/>.
		/// </summary>
		public RespIdDeleted dispatchTask;
	}
}