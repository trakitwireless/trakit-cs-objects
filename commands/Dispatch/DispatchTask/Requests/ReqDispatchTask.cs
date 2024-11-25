using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="dispatchTask"/> object.
	/// </summary>
	public abstract class ReqDispatchTask : Request, IReqSingle {
		/// <summary>
		/// An object to contain the "id" of the <see cref="DispatchTask"/>.
		/// </summary>
		public ParamId dispatchTask { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.dispatchTask?.id.ToString() ?? "";
	}
}