using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="FormResult"/>.
	/// </summary>
	public class ReqFormResultGet : ReqFormResult, IReqIDeletable {
		/// <summary>
		/// When true, the command will also return a deleted <see cref="FormResult"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}
}