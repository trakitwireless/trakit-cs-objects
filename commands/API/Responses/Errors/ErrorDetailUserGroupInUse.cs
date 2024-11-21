namespace Trakit.Commands {
	/// <summary>
	/// Details for how many and which <see cref="User"/>s are still in the <see cref="UserGroup"/>.
	/// </summary>
	public class ErrorDetailUserGroupInUse : ErrorDetail {
		/// <summary>
		/// A list of <see cref="User"/>s currently being referenced.
		/// </summary>
		public string[] users;
	}
}