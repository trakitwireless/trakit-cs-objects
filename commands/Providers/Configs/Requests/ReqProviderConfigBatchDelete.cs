using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqProviderConfigBatchDelete : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamId> providerConfigs { get; set; }
	}
}