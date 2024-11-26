using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="assetMessage"/>.
	/// </summary>
	public class RespAssetMessageGet : Response {
		/// <summary>
		/// The requested <see cref="AssetMessage"/>.
		/// </summary>
		public AssetMessage assetMessage;
	}
}