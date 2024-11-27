using System;
using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	[Obsolete("Use ReqProviderConfigBatchMerge instead")]
	public class ReqProviderConfigurationBatchMerge : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamProviderConfigurationMerge> providerConfigurations { get; set; }
	}
}