using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqPictureBatchMerge : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamPictureMerge> pictures { get; set; }
	}
}