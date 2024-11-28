using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqProviderConfigBatchMerge : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamProviderConfigMerge> providerConfigs { get; set; }
	}
}