using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqIconBatchDelete : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamId> icons { get; set; }
	}
}