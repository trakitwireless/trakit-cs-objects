namespace Trakit.Commands {
	/// <summary>
	/// For delete/restore commands, this contains the id, owning <see cref="Company.parent"/>, and deleted state.
	/// </summary>
	public class RespParentDeleted : RespId {
		/// <summary>
		/// Identifier of the <see cref="Company">parent</see> to which the <see cref="Company"/> is a child.
		/// </summary>
		public ulong parent;
		/// <summary>
		/// Flag showing if the object is deleted.
		/// </summary>
		public bool deleted;
		/// <summary>
		/// Object version keys used to validate synchronization for all object properties.
		/// </summary>
		public uint[] v;
	}
}