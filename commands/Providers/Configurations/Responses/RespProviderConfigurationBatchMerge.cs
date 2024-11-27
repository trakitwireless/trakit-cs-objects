using System;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	[Obsolete("Use RespProviderConfigBatchMerge instead")]
	public class RespProviderConfigurationBatchMerge : Response {
		/// <summary>
		/// 
		/// </summary>
		public RespIdCompany[] providerConfigurations;
	}
}