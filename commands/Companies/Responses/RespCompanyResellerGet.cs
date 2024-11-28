using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="companyReseller"/>.
	/// </summary>
	public class RespCompanyResellerGet : Response {
		/// <summary>
		/// The requested <see cref="CompanyReseller"/>.
		/// </summary>
		public CompanyReseller companyReseller;
	}
}