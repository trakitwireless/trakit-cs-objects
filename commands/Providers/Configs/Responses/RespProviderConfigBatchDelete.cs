using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="providerConfig"/>.
	/// </summary>
	public class RespProviderConfigBatchDelete : Response {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="ProviderConfig"/>.
		/// </summary>
		public RespIdDeleted[] providerConfigs;
	}
}