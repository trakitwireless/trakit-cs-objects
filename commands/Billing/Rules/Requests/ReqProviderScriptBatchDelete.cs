using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqBillableHostingRuleBatchDelete : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamId> hostingRules { get; set; }
	}
}