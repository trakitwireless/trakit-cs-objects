using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqMachineBatchDelete : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamLogin> machines { get; set; }
	}
}