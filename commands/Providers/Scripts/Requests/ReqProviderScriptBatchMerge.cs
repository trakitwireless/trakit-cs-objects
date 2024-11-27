using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqProviderScriptBatchMerge : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamProviderScriptMerge> providerScripts { get; set; }
	}
}