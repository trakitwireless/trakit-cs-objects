using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="machine"/>.
	/// </summary>
	public class RespMachineDelete : Response {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="Machine"/>.
		/// </summary>
		public RespDeleted machine;
	}
}