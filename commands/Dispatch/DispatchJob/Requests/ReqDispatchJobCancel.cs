using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Cancels a <see cref="DispatchJob"/>, removing it from the dispatcher's and driver's views.
	/// </summary>
	public class ReqDispatchJobCancel : Request, IReqSingle {
		/// <summary>
		/// Parameters given to cancel a <see cref="DispatchJob"/>.
		/// </summary>
		public ParamDispatchJobCancel dispatchJob { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.dispatchJob.id.ToString() ?? "";
	}
}