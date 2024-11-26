using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="Company"/>.
	/// </summary>
	public class ReqCompanyGet : ReqCompany, IReqIDeletable {
		/// <summary>
		/// When true, the command will also return a deleted <see cref="Company"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}
}