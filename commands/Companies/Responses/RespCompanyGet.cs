using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="company"/>.
	/// </summary>
	public class RespCompanyGet : Response {
		/// <summary>
		/// The requested <see cref="Company"/>.
		/// </summary>
		public Company company;
	}
}