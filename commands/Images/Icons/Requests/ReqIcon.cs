using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="icon"/> object.
	/// </summary>
	public abstract class ReqIcon : Request, IReqSingle {
		/// <summary>
		/// An object to contain the "id" of the <see cref="Icon"/>.
		/// </summary>
		public ParamId icon { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.icon?.id.ToString() ?? "";
	}
}