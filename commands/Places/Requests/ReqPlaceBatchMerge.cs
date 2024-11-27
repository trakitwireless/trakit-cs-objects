using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqPlaceBatchMerge : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamPlaceMerge> places { get; set; }
	}
}