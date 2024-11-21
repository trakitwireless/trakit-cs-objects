using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="Contact"/>.
	/// </summary>
	public class ReqContactGet : ReqContact, IReqIDeletable {
		/// <summary>
		/// When true, the command will also return a deleted <see cref="Contact"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}
}