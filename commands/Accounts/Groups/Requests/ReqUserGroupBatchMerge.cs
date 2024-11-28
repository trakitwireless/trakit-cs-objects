using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqUserGroupBatchMerge : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamUserGroupMerge> userGroups { get; set; }
	}
}