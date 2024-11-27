using System;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="providerConfigurationType"/> object.
	/// </summary>
	[Obsolete("Use ReqProviderScript instead")]
	public abstract class ReqProviderConfigurationType : Request, IReqSingle {
		/// <summary>
		/// An object to contain the "id" of the <see cref="ProviderConfigurationType"/>.
		/// </summary>
		public ParamId providerConfigurationType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.providerConfigurationType?.id.ToString() ?? "";
	}
}