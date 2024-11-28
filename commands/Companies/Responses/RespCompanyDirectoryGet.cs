using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="companyDirectory"/>.
	/// </summary>
	public class RespCompanyDirectoryGet : Response {
		/// <summary>
		/// The requested <see cref="CompanyDirectory"/>.
		/// </summary>
		public CompanyDirectory companyDirectory;
	}
}