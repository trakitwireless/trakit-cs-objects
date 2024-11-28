using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="document"/> object.
	/// </summary>
	public abstract class ReqDocument : Request, IReqSingle {
		/// <summary>
		/// An object to contain the "id" of the <see cref="Document"/>.
		/// </summary>
		public ParamId document { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.document?.id.ToString() ?? "";
	}
}