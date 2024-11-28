using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqFormResultBatchDelete : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamId> formResults { get; set; }
	}
}