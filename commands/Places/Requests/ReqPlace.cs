using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="place"/> object.
	/// </summary>
	public abstract class ReqPlace : Request, IReqSingle {
		/// <summary>
		/// An object to contain the "id" of the <see cref="Place"/>.
		/// </summary>
		public ParamId place { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.place?.id.ToString() ?? "";
	}
}