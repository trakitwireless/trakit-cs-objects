using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="formTemplate"/> object.
	/// </summary>
	public abstract class ReqFormTemplate : Request, IReqSingle {
		/// <summary>
		/// An object to contain the "id" of the <see cref="FormTemplate"/>.
		/// </summary>
		public ParamId formTemplate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.formTemplate?.id.ToString() ?? "";
	}
}