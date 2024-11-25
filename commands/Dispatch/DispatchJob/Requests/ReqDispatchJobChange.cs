using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Completes or modifies an existing <see cref="DispatchJob"/> from a driver's perspective.
	/// This can be used by dispatchers to accomodate thrid-party delivery systems, or correcting errors from drivers.
	/// </summary>
	public class ReqDispatchJobChange : Request, IReqSingle {
		/// <summary>
		/// Parameters given to create or update a <see cref="DispatchJob"/>.
		/// </summary>
		public ParamDispatchJobChange dispatchJob { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.dispatchJob?.id.ToString() ?? "";
	}
}