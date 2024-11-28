using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="providerRegistration"/>.
	/// </summary>
	public class RespProviderRegistrationDelete : Response {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="ProviderRegistration"/>.
		/// </summary>
		public RespIdDeleted providerRegistration;
	}
}