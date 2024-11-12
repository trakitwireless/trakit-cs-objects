using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="asset"/>.
	/// </summary>
	public class RespAssetGet : Response {
		/// <summary>
		/// The requested <see cref="Asset"/>.
		/// </summary>
		public Asset asset;
	}
}