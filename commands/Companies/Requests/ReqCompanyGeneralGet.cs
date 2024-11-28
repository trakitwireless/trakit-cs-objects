using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="CompanyGeneral"/>.
	/// </summary>
	public class ReqCompanyGeneralGet : ReqCompany, IReqIDeletable {
		/// <summary>
		/// When true, the command will also return a deleted <see cref="CompanyGeneral"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}
}