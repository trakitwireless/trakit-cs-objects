using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="dispatchJob"/>.
	/// </summary>
	public class RespDispatchJobGet : Response {
		/// <summary>
		/// The requested <see cref="DispatchJob"/>.
		/// </summary>
		public DispatchJob dispatchJob;
	}
}