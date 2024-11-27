using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="providerConfig"/>.
	/// </summary>
	public class RespProviderConfigDelete : Response {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="ProviderConfig"/>.
		/// </summary>
		public RespDeleted providerConfig;
	}
}