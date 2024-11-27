using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="place"/>.
	/// </summary>
	public class RespPlaceBatchDelete : Response {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="Place"/>.
		/// </summary>
		public RespDeleted[] places;
	}
}