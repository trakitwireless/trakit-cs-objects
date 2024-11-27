using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Creates a new or updates an existing <see cref="ProviderScript"/>.
	/// </summary>
	public class ReqProviderScriptMerge : Request, IReqSingle {
		/// <summary>
		/// Parameters given to create or update a <see cref="ProviderScript"/>.
		/// </summary>
		public ParamProviderScriptMerge providerScript { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.providerScript?.id?.ToString() ?? "";
	}
}