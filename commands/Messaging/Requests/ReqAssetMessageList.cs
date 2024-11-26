using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="assetMessage"/>.
	/// </summary>
	public abstract class ReqAssetMessageList : Request, IReqIDeletable {
		/// <summary>
		/// When true, the command will also return  deleted <see cref="AssetMessage"/>s.
		/// </summary>
		public bool includeDeleted { get; set; }
	}

	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class ReqAssetMessageListByCompany : ReqAssetMessageList, IReqListByCompany {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ParamId company { get; set; }
	}
	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class ReqAssetMessageListByAsset : ReqAssetMessageList, IReqListByAsset {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ParamId asset { get; set; }
	}
}