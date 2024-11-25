using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Creates a new or updates an existing <see cref="DispatchJob"/>.
	/// </summary>
	public class ReqDispatchJobMerge : Request, IReqSingle {
		/// <summary>
		/// Parameters given to create or update a <see cref="DispatchJob"/>.
		/// </summary>
		public ParamDispatchJobMerge dispatchJob { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.dispatchJob?.id?.ToString() ?? "";
	}
}