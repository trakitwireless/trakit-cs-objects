using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Creates multiple new, or updates multiple existing <see cref="DispatchTask"/>s.
	/// </summary>
	public class ReqDispatchTaskBatchMerge : Request {
		/// <summary>
		/// List of <see cref="DispatchTask"/>s to update or create.
		/// </summary>
		public List<ParamDispatchTaskMerge> dispatchTasks { get; set; }
	}
}