using System;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="providerConfiguration"/>.
	/// </summary>
	[Obsolete("Use RespProviderConfigGet instead")]
	public class RespProviderConfigurationGet : Response {
		/// <summary>
		/// The requested <see cref="ProviderConfiguration"/>.
		/// </summary>
		public ProviderConfiguration providerConfiguration;
	}
}