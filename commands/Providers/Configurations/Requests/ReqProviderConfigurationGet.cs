using System;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="ProviderConfiguration"/>.
	/// </summary>
	[Obsolete("Use ReqProviderConfigGet instead")]
	public class ReqProviderConfigurationGet : ReqProviderConfiguration, IReqIDeletable {
		/// <summary>
		/// When true, the command will also return a deleted <see cref="ProviderConfiguration"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}
}