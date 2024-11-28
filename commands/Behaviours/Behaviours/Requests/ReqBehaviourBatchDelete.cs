using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqBehaviourBatchDelete : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamId> behaviours { get; set; }
	}
}