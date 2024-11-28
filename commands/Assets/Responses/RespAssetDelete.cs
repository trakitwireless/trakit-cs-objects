using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// For delete/restore commands, this contains the <see cref="Asset.id"/>, owning <see cref="Company.id"/>, and deleted state.
	/// </summary>
	public class RespAssetDelete : Response {
		/// <summary>
		/// 
		/// </summary>
		public RespIdDeleted asset;
	}
}