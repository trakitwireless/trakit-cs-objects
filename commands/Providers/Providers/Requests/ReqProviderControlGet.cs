using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="ProviderControl"/>.
	/// </summary>
	public class ReqProviderControlGet : ReqProvider, IReqIDeletable {
		/// <summary>
		/// When true, the command will also return a deleted <see cref="ProviderControl"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}
}