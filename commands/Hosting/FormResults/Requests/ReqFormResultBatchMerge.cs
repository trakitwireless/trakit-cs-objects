using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqFormResultBatchMerge : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamFormResultMerge> formResults { get; set; }
	}
}