using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="CompanyStyles"/>.
	/// </summary>
	public class ReqCompanyStylesGet : ReqCompany, IReqIDeletable {
		/// <summary>
		/// When true, the command will also return  deleted <see cref="CompanyStyles"/>s.
		/// </summary>
		public bool includeDeleted { get; set; }
	}
}