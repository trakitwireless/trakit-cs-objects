using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="CompanyReseller"/>.
	/// </summary>
	public class ReqCompanyResellerGet : ReqCompany, IReqIDeletable {
		/// <summary>
		/// When true, the command will also return a deleted <see cref="CompanyReseller"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}
}