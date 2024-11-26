using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="User"/>.
	/// </summary>
	public class ReqUserGet : ReqUser, IReqIDeletable {
		/// <summary>
		/// When true, the command will also return a deleted <see cref="User"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}
}