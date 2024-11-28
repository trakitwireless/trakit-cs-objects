using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="providerControl"/>.
	/// </summary>
	public class RespProviderControlGet : Response {
		/// <summary>
		/// The requested <see cref="ProviderControl"/>.
		/// </summary>
		public ProviderControl providerControl;
	}
}