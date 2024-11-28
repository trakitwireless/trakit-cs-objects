using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="provider"/>.
	/// </summary>
	public class RespProviderDelete : Response {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="Provider"/>.
		/// </summary>
		public RespIdendifierDeleted provider;
	}
}