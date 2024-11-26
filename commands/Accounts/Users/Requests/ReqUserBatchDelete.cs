using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqUserBatchDelete : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamLogin> users { get; set; }
	}
}