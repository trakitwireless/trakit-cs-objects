using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="company"/>.
	/// </summary>
	public class RespCompanyDelete : Response {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="Company"/>.
		/// </summary>
		public RespDeleted company;
	}
}