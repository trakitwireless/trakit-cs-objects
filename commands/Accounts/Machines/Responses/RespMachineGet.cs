using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="machine"/>.
	/// </summary>
	public class RespMachineGet : Response {
		/// <summary>
		/// The requested <see cref="Machine"/>.
		/// </summary>
		public Machine machine;
	}
}