using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqContactBatchDelete : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamId> contacts { get; set; }
	}
}