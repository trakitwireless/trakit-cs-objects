using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="ProviderConfig"/>.
	/// </summary>
	public class ReqProviderConfigGet : ReqProviderConfig, IReqIDeletable {
		/// <summary>
		/// When true, the command will also return a deleted <see cref="ProviderConfig"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}
}