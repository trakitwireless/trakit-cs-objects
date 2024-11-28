using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="CompanyDirectory"/>.
	/// </summary>
	public class ReqCompanyDirectoryGet : ReqCompany, IReqIDeletable {
		/// <summary>
		/// When true, the command will also return a deleted <see cref="CompanyDirectory"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}
}