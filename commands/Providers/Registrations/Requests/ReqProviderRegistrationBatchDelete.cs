using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqProviderRegistrationBatchDelete : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamCode> providerRegistrations { get; set; }
	}
}