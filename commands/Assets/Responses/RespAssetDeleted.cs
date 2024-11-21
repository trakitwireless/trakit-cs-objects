using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// For delete/restore commands, this contains the <see cref="Asset.id"/>, owning <see cref="Company.id"/>, and deleted state.
	/// </summary>
	public class RespAssetDeleted : Response {
		/// <summary>
		/// 
		/// </summary>
		public RespDeleted asset;
	}
}