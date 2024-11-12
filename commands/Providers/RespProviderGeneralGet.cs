using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="providerGeneral"/>.
	/// </summary>
	public class RespProviderGeneralGet : Response {
		/// <summary>
		/// The requested <see cref="Provider"/>.
		/// </summary>
		public ProviderGeneral providerGeneral;
	}
}