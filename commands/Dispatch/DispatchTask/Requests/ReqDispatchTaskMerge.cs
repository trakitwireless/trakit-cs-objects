using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Creates a new or updates an existing <see cref="DispatchTask"/>.
	/// </summary>
	public class ReqDispatchTaskMerge : Request, IReqSingle {
		/// <summary>
		/// Parameters given to create or update a <see cref="DispatchTask"/>.
		/// </summary>
		public ParamDispatchTaskMerge dispatchTask { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.dispatchTask?.id?.ToString() ?? "";
	}
}