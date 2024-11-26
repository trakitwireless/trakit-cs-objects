using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqCompanyBatchDelete : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamId> companies { get; set; }
	}
}