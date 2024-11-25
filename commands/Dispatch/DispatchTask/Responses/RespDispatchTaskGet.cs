using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="dispatchTask"/>.
	/// </summary>
	public class RespDispatchTaskGet : Response {
		/// <summary>
		/// The requested <see cref="DispatchTask"/>.
		/// </summary>
		public DispatchTask dispatchTask;
	}
}