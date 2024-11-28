using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqBehaviourScriptBatchMerge : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamBehaviourScriptMerge> behaviourScripts { get; set; }
	}
}