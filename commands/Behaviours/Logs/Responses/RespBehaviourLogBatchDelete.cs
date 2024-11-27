using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="behaviourLog"/>.
	/// </summary>
	public class RespBehaviourLogBatchDelete : Response {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="BehaviourLog"/>.
		/// </summary>
		public RespDeleted[] behaviourLogs;
	}
}