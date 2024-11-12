namespace Trakit.Commands {
	/// <summary>
	/// For suspend/revive commands, this contains the id, version keys, owning <see cref="Company.id"/>, and suspended state.
	/// </summary>
	public class RespSuspended : RespIdCompany {
		/// <summary>
		/// Flag showing if the object is suspended.
		/// </summary>
		public bool suspended;
		/// <summary>
		/// Object version keys used to validate synchronization for all object properties.
		/// </summary>
		public uint[] v;
	}
}