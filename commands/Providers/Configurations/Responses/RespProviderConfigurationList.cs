using System;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="providerConfigurations"/>.
	/// </summary>
	[Obsolete("Use RespProviderConfigList instead")]
	public abstract class RespProviderConfigurationList : Response {
		/// <summary>
		/// The list of requested <see cref="ProviderConfiguration"/>s.
		/// </summary>
		public ProviderConfiguration[] providerConfigurations;
	}

	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	[Obsolete("Use RespProviderConfigListByCompany instead")]
	public class RespProviderConfigurationListByCompany : RespProviderConfigurationList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public RespId company;
	}
}