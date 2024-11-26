using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqCompanyBatchMerge : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamCompanyMerge> companies { get; set; }
	}
}