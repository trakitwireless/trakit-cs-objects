using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="AssetGeneral"/>.
	/// </summary>
	public class ReqAssetGeneralGet : ReqAsset, IReqIDeletable {
		/// <summary>
		/// When true, the command will also return a deleted <see cref="AssetGeneral"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
		/// <summary>
		/// When true, the command will also return <see cref="AssetGeneralMessage"/>s for the asset.
		/// </summary>
		public bool includeMessages { get; set; }
		/// <summary>
		/// When true, the command will also return <see cref="DispatchTask"/>s for the asset.
		/// </summary>
		public bool includeTasks { get; set; }
	}
}