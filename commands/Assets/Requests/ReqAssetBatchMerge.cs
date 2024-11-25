using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqAssetBatchMerge : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamAssetMerge> assets { get; set; }
	}
}