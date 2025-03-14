namespace Trakit.Objects {
	/// <summary>
	/// How a permission is applied.
	/// </summary>
	public enum PermissionMethod : byte {
		/// <summary>
		/// Permission is given.
		/// </summary>
		grant,
		/// <summary>
		/// Permission is taken away.
		/// </summary>
		revoke,
	}
}