using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqProviderBatchMerge : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamProviderMerge> providers { get; set; }
	}
}