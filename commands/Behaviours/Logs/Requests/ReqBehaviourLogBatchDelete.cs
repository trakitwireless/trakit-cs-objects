using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqBehaviourLogBatchDelete : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamId> behaviourLogs { get; set; }
	}
}