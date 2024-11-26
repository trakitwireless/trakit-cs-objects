using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="userGroup"/> object.
	/// </summary>
	public abstract class ReqUserGroup : Request, IReqSingle {
		/// <summary>
		/// An object to contain the "id" of the <see cref="UserGroup"/>.
		/// </summary>
		public ParamId userGroup { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.userGroup?.id.ToString() ?? "";
	}
}