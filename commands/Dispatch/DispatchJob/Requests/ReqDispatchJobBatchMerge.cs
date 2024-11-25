using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Creates multiple new, or updates multiple existing <see cref="DispatchJob"/>s.
	/// </summary>
	public class ReqDispatchJobBatchMerge : Request {
		/// <summary>
		/// List of <see cref="DispatchJob"/>s to update or create.
		/// </summary>
		public List<ParamDispatchJobMerge> dispatchJobs { get; set; }
	}
}