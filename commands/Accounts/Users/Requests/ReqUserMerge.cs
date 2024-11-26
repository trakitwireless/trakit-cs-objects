using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Creates a new or updates an existing <see cref="User"/>.
	/// </summary>
	public class ReqUserMerge : Request, IReqSingle {
		/// <summary>
		/// Parameters given to create or update a <see cref="User"/>.
		/// </summary>
		public ParamUserMerge user { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.user?.login ?? "";
	}
}