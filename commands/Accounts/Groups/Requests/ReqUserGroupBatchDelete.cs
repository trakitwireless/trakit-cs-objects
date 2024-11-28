using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqUserGroupBatchDelete : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamId> userGroups { get; set; }
	}
}