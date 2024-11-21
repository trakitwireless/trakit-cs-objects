namespace Trakit.Commands {
	/// <summary>
	/// For delete/restore commands, this contains the id, version keys, owning <see cref="Company.id"/>, and deleted state.
	/// </summary>
	public abstract class RespDeleted : RespIdCompany {
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