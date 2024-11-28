using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqDocumentBatchMerge : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamDocumentMerge> documents { get; set; }
	}
}