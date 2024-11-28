using System;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="providerConfiguration"/>.
	/// </summary>
	[Obsolete("Use RespProviderConfigDelete instead")]
	public class RespProviderConfigurationDelete : Response {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="ProviderConfiguration"/>.
		/// </summary>
		public RespIdDeleted providerConfiguration;
	}
}