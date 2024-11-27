using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqBehaviourBatchMerge : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamBehaviourMerge> behaviours { get; set; }
	}
}