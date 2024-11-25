using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqAssetBatchDelete : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamId> assets { get; set; }
	}
}