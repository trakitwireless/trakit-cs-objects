using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqUserBatchMerge : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamUserMerge> users { get; set; }
	}
}