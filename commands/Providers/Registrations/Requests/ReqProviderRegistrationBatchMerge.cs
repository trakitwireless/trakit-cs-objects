using System.Collections.Generic;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqProviderRegistrationBatchMerge : Request {
		/// <summary>
		/// 
		/// </summary>
		public List<ParamProviderRegistrationMerge> providerRegistrations { get; set; }
	}
}