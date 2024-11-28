using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Creates a new or updates an existing <see cref="ProviderRegistration"/>.
	/// </summary>
	public class ReqProviderRegistrationMerge : Request, IReqSingle {
		/// <summary>
		/// Parameters given to create or update a <see cref="ProviderRegistration"/>.
		/// </summary>
		public ParamProviderRegistrationMerge providerRegistration { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.providerRegistration?.code ?? "";
	}
}