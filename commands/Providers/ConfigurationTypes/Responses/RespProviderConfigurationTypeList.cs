using System;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="providerConfigurationTypes"/>.
	/// </summary>
	[Obsolete("Use RespProviderScriptList instead")]
	public abstract class RespProviderConfigurationTypeList : Response {
		/// <summary>
		/// The list of requested <see cref="ProviderConfigurationType"/>s.
		/// </summary>
		public ProviderConfigurationType[] providerConfigurationTypes;
	}

	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	[Obsolete("Use RespProviderScriptListByCompany instead")]
	public class RespProviderConfigurationTypeListByCompany : RespProviderConfigurationTypeList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public RespId company;
	}
}