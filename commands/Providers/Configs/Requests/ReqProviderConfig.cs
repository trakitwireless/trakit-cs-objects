using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="providerConfig"/> object.
	/// </summary>
	public abstract class ReqProviderConfig : Request, IReqSingle {
		/// <summary>
		/// An object to contain the "id" of the <see cref="ProviderConfig"/>.
		/// </summary>
		public ParamId providerConfig { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.providerConfig?.id.ToString() ?? "";
	}
}