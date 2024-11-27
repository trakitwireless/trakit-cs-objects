using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqDocumentBatchDelete : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamId> documents { get; set; }
	}
}