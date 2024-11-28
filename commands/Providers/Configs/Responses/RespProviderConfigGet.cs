using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="providerConfig"/>.
	/// </summary>
	public class RespProviderConfigGet : Response {
		/// <summary>
		/// The requested <see cref="ProviderConfig"/>.
		/// </summary>
		public ProviderConfig providerConfig;
	}
}