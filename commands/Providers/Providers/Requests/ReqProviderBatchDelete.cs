using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqProviderBatchDelete : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamIdentifier> providers { get; set; }
	}
}