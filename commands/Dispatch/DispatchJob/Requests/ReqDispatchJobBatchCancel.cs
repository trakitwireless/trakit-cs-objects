using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Cancels multiple existing <see cref="DispatchJob"/>s, removing them from the dispatcher's and driver's views.
	/// </summary>
	public class ReqDispatchJobBatchCancel : Request {
		/// <summary>
		/// List of <see cref="DispatchJob"/>s to update or create.
		/// </summary>
		public List<ParamDispatchJobCancel> dispatchJobs { get; set; }
	}
}