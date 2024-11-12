namespace Trakit.Commands {
	/// <summary>
	/// A container for the id, owning <see cref="Asset.id"/>, and owning <see cref="Company.id"/> of the object requested/created.
	/// </summary>
	public class RespIdAsset : RespIdCompany {
		/// <summary>
		/// Identifier of the <see cref="Asset"/> to which this object belongs
		/// </summary>
		public ulong asset;
	}
}