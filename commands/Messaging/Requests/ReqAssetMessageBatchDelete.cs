using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqAssetMessageBatchDelete : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamId> assetMessages { get; set; }
	}
}