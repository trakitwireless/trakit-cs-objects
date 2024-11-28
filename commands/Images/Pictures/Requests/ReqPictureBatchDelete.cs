using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqPictureBatchDelete : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamId> pictures { get; set; }
	}
}