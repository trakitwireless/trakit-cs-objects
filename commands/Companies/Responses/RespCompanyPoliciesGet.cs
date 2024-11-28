using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="companyPolicies"/>.
	/// </summary>
	public class RespCompanyPoliciesGet : Response {
		/// <summary>
		/// The requested <see cref="CompanyPolicies"/>.
		/// </summary>
		public CompanyPolicies companyPolicies;
	}
}