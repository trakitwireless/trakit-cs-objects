using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqReportTemplateBatchMerge : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamReportTemplateMerge> reportTemplates { get; set; }
	}
}