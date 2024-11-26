using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="assetMessage"/> object.
	/// </summary>
	public abstract class ReqAssetMessage : Request, IReqSingle {
		/// <summary>
		/// An object to contain the "id" of the <see cref="AssetMessage"/>.
		/// </summary>
		public ParamId assetMessage { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.assetMessage?.id.ToString() ?? "";
	}
}