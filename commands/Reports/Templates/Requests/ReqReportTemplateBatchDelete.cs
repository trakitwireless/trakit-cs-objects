using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqReportTemplateBatchDelete : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamId> reportTemplates { get; set; }
	}
}