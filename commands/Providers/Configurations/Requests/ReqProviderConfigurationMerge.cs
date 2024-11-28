using System;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Creates a new or updates an existing <see cref="ProviderConfiguration"/>.
	/// </summary>
	[Obsolete("Use ReqProviderConfigMerge instead")]
	public class ReqProviderConfigurationMerge : Request, IReqSingle {
		/// <summary>
		/// Parameters given to create or update a <see cref="ProviderConfiguration"/>.
		/// </summary>
		public ParamProviderConfigurationMerge providerConfiguration { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.providerConfiguration?.id?.ToString() ?? "";
	}
}