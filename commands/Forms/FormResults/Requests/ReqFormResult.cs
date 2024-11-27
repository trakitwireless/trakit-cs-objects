using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="formResult"/> object.
	/// </summary>
	public abstract class ReqFormResult : Request, IReqSingle {
		/// <summary>
		/// An object to contain the "id" of the <see cref="FormResult"/>.
		/// </summary>
		public ParamId formResult { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.formResult?.id.ToString() ?? "";
	}
}