using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqFormTemplateBatchDelete : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamId> formTemplates { get; set; }
	}
}