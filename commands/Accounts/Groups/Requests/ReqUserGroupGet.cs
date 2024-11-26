using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="UserGroup"/>.
	/// </summary>
	public class ReqUserGroupGet : ReqUserGroup, IReqIDeletable {
		/// <summary>
		/// When true, the command will also return a deleted <see cref="UserGroup"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}
}