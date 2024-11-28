using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Creates a new or updates an existing <see cref="UserGroup"/>.
	/// </summary>
	public class ReqUserGroupMerge : Request, IReqSingle {
		/// <summary>
		/// Parameters given to create or update a <see cref="UserGroup"/>.
		/// </summary>
		public ParamUserGroupMerge userGroup { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.userGroup?.id?.ToString() ?? "";
	}
}