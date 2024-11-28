using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="providerScript"/> object.
	/// </summary>
	public abstract class ReqProviderScript : Request, IReqSingle {
		/// <summary>
		/// An object to contain the "id" of the <see cref="ProviderScript"/>.
		/// </summary>
		public ParamId providerScript { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.providerScript?.id.ToString() ?? "";
	}
}