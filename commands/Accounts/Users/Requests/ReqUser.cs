using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="user"/> object.
	/// </summary>
	public abstract class ReqUser : Request, IReqSingle {
		/// <summary>
		/// An object to contain the "id" of the <see cref="User"/>.
		/// </summary>
		public ParamLogin user { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.user?.login ?? "";
	}
}