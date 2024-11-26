using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="AssetMessage"/>.
	/// </summary>
	public class ReqAssetMessageGet : ReqAssetMessage, IReqIDeletable {
		/// <summary>
		/// When true, the command will also return a deleted <see cref="AssetMessage"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}
}