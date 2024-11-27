using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="FormTemplate"/>.
	/// </summary>
	public class ReqFormTemplateGet : ReqFormTemplate, IReqIDeletable {
		/// <summary>
		/// When true, the command will also return a deleted <see cref="FormTemplate"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}
}