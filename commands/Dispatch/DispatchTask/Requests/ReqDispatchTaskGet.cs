using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="DispatchTask"/>.
	/// </summary>
	public class ReqDispatchTaskGet : ReqDispatchTask, IReqIDeletable {
		/// <summary>
		/// When true, the command will also return a deleted <see cref="DispatchTask"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}
}