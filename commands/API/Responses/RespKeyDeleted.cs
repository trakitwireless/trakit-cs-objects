namespace Trakit.Commands {
	/// <summary>
	/// For delete/restore commands, this contains the <see cref="Machine.key"/>, version keys, owning <see cref="Company.id"/>, and deleted state.
	/// </summary>
	public class RespKeyDeleted : RespKeyCompany {
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