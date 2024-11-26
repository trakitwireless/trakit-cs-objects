using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="assetMessages"/>.
	/// </summary>
	public abstract class RespAssetMessageList : Response {
		/// <summary>
		/// The list of requested <see cref="AssetMessage"/>s.
		/// </summary>
		public AssetMessage[] assetMessages;
	}

	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class RespAssetMessageListByCompany : RespAssetMessageList, IRespListByCompany {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public RespId company { get; set; }
	}
	/// <summary>
	/// Contains the <see cref="Asset.id"/> of the collection.
	/// </summary>
	public class RespAssetMessageListByAsset : RespAssetMessageList, IRespListByAsset {
		/// <summary>
		/// Identifier of the <see cref="Asset"/> to which this collection belongs.
		/// </summary>
		public RespId asset { get; set; }
	}
}