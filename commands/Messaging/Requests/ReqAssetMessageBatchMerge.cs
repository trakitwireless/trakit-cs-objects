using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqAssetMessageBatchMerge : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamAssetMessageMerge> assetMessages { get; set; }
	}
}