using System;
using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	[Obsolete("Use ReqProviderConfigBatchDelete instead")]
	public class ReqProviderConfigurationBatchDelete : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamId> providerConfigurations { get; set; }
	}
}