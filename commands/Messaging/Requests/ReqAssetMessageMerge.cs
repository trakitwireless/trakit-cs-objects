using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Creates a new or updates an existing <see cref="AssetMessage"/>.
	/// </summary>
	public class ReqAssetMessageMerge : Request, IReqSingle {
		/// <summary>
		/// Parameters given to create or update a <see cref="AssetMessage"/>.
		/// </summary>
		public ParamAssetMessageMerge assetMessage { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.assetMessage?.id?.ToString() ?? "";
	}
}