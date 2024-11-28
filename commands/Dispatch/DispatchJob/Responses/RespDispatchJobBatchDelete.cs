using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="dispatchJob"/>.
	/// </summary>
	public class RespDispatchJobBatchDelete : Response {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="DispatchJob"/>.
		/// </summary>
		public RespIdDeleted[] dispatchJobs;
	}
}