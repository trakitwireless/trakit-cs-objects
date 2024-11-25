using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Deletes multiple <see cref="DispatchTask"/>s.
	/// </summary>
	public class ReqDispatchTaskBatchDelete : Request {
		/// <summary>
		/// List of <see cref="DispatchTask.id"/>s to delete.
		/// </summary>
		public List<ParamId> dispatchTasks { get; set; }
	}
}