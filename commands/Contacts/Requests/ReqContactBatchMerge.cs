using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqContactBatchMerge : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamContactMerge> contacts { get; set; }
	}
}