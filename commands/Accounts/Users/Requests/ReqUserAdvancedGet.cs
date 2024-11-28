using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="UserAdvanced"/>.
	/// </summary>
	public class ReqUserAdvancedGet : ReqUser, IReqIDeletable {
		/// <summary>
		/// When true, the command will also return a deleted <see cref="UserAdvanced"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}
}