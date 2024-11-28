using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="assetMessage"/>.
	/// </summary>
	public class RespAssetMessageDelete : Response {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="AssetMessage"/>.
		/// </summary>
		public RespIdDeleted assetMessage;
	}
}