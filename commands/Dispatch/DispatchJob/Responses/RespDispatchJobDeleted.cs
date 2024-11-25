using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="dispatchJob"/>.
	/// </summary>
	public class RespDispatchJobDeleted : Response {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="DispatchJob"/>.
		/// </summary>
		public RespDeleted dispatchJob;
	}
}