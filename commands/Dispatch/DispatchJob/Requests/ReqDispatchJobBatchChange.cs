using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Completes or modifies multiple existing <see cref="DispatchJob"/>s from a driver's perspective.
	/// </summary>
	public class ReqDispatchJobBatchChange : Request {
		/// <summary>
		/// List of <see cref="DispatchJob"/>s to update or create.
		/// </summary>
		public List<ParamDispatchJobChange> dispatchJobs { get; set; }
	}
}