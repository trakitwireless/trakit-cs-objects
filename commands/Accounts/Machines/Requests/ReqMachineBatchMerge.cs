using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqMachineBatchMerge : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamMachineMerge> machines { get; set; }
	}
}