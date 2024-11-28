using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="providerRegistration"/> object.
	/// </summary>
	public abstract class ReqProviderRegistration : Request, IReqSingle {
		/// <summary>
		/// An object to contain the "id" of the <see cref="ProviderRegistration"/>.
		/// </summary>
		public ParamCode providerRegistration { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.providerRegistration?.code.ToString() ?? "";
	}
}