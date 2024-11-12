namespace Trakit.Commands {
	/// <summary>
	/// For delete/restore commands, this contains the id, owning <see cref="Asset.id"/>, owning <see cref="Company.id"/>, and deleted state.
	/// </summary>
	public class RespAssetDeleted : RespDeleted {
		/// <summary>
		/// Identifier of the <see cref="Asset"/> to which this object belongs.
		/// </summary>
		public ulong asset;
	}
}