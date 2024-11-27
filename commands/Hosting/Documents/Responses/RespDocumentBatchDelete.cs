using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="document"/>.
	/// </summary>
	public class RespDocumentBatchDelete : Response {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="Document"/>.
		/// </summary>
		public RespDeleted[] documents;
	}
}