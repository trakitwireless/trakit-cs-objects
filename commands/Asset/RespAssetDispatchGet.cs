using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="assetDispatch"/>.
	/// </summary>
	public class RespAssetDispatchGet : Response {
		/// <summary>
		/// The requested <see cref="AssetDispatch"/>.
		/// </summary>
		public AssetDispatch assetDispatch;
	}
}