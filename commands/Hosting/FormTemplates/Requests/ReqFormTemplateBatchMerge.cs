using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqFormTemplateBatchMerge : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamFormTemplateMerge> formTemplates { get; set; }
	}
}