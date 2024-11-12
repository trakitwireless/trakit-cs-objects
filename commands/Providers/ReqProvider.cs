using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="provider"/> object.
	/// </summary>
	public abstract class ReqProvider : Request, IReqSingle {
		/// <summary>
		/// An object to contain the "id" of the <see cref="Provider"/>.
		/// </summary>
		public ParamIdentifier provider { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string getKey() => this.provider?.id ?? "";
	}
}