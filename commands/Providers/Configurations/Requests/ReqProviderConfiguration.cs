using System;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="providerConfiguration"/> object.
	/// </summary>
	[Obsolete("Use ReqProviderConfig instead")]
	public abstract class ReqProviderConfiguration : Request, IReqSingle {
		/// <summary>
		/// An object to contain the "id" of the <see cref="ProviderConfiguration"/>.
		/// </summary>
		public ParamId providerConfiguration { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.providerConfiguration?.id.ToString() ?? "";
	}
}