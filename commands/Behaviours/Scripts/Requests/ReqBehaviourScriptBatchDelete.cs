using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqBehaviourScriptBatchDelete : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamId> behaviourScripts { get; set; }
	}
}