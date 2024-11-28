using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="formResult"/>.
	/// </summary>
	public class RespFormResultGet : Response {
		/// <summary>
		/// The requested <see cref="FormResult"/>.
		/// </summary>
		public FormResult formResult;
	}
}