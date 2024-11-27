using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="document"/>.
	/// </summary>
	public class RespDocumentGet : Response {
		/// <summary>
		/// The requested <see cref="Document"/>.
		/// </summary>
		public Document document;
	}
}