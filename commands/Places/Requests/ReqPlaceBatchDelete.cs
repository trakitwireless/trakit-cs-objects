using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqPlaceBatchDelete : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamId> places { get; set; }
	}
}