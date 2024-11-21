namespace Trakit.Commands {
	/// <summary>
	/// A container for the id and the requested/created <see cref="Company.parent"/>.
	/// </summary>
	public class RespIdParent : RespId {
		/// <summary>
		/// Identifier of the parent to which this company belongs
		/// </summary>
		public ulong? parent;
	}
}