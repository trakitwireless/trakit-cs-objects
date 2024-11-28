using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="companyStyles"/>.
	/// </summary>
	public class RespCompanyStylesGet : Response {
		/// <summary>
		/// The requested <see cref="CompanyStyles"/>.
		/// </summary>
		public CompanyStyles companyStyles;
	}
}