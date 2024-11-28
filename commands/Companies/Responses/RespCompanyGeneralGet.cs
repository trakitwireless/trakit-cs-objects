using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="companyGeneral"/>.
	/// </summary>
	public class RespCompanyGeneralGet : Response {
		/// <summary>
		/// The requested <see cref="CompanyGeneral"/>.
		/// </summary>
		public CompanyGeneral companyGeneral;
	}
}