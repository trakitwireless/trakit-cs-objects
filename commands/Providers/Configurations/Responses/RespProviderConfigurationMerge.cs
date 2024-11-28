using System;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="providerConfiguration"/>.
	/// </summary>
	[Obsolete("Use RespProviderConfigMerge instead")]
	public class RespProviderConfigurationMerge : Response {
		/// <summary>
		/// An object which contains the <c>id</c> and <c>company</c> keys when there is no error.
		/// </summary>
		public RespIdCompany providerConfiguration;
	}
}