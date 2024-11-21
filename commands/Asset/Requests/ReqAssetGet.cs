using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="Asset"/>.
	/// </summary>
	public class ReqAssetGet : ReqAsset, IReqIDeletable {
		/// <summary>
		/// When true, the command will also return a deleted <see cref="Asset"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
		/// <summary>
		/// When true, the command will also return <see cref="AssetMessage"/>s for the asset.
		/// </summary>
		public bool includeMessages { get; set; }
		/// <summary>
		/// When true, the command will also return <see cref="DispatchTask"/>s for the asset.
		/// </summary>
		public bool includeTasks { get; set; }
	}
}