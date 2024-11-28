using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="company"/>.
	/// </summary>
	public class RespCompanyBatchDelete : Response {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="Company"/>.
		/// </summary>
		public RespIdDeleted[] companies;
	}
}