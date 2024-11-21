using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="AssetAdvanced"/>.
	/// </summary>
	public class ReqAssetAdvancedGet : ReqAsset, IReqIDeletable {
		/// <summary>
		/// When true, the command will also return a deleted <see cref="AssetAdvanced"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}
}