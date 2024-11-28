using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqBillableHostingRuleBatchMerge : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamBillableHostingRuleMerge> hostingRules { get; set; }
	}
}