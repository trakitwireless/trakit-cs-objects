using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="providerRegistration"/>.
	/// </summary>
	public class RespProviderRegistrationBatchDelete : Response {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="ProviderRegistration"/>.
		/// </summary>
		public RespCodeDeleted[] providerRegistrations;
	}
}