using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqProviderScriptBatchDelete : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamId> providerScripts { get; set; }
	}
}