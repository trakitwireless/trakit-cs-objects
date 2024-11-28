using System;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="providerConfigurationType"/>.
	/// </summary>
	[Obsolete("Use RespProviderScriptGet instead")]
	public class RespProviderConfigurationTypeGet : Response {
		/// <summary>
		/// The requested <see cref="ProviderConfigurationType"/>.
		/// </summary>
		public ProviderConfigurationType providerConfigurationType;
	}
}