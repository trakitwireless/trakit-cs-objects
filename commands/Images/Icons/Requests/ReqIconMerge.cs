using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Creates a new or updates an existing <see cref="Icon"/>.
	/// </summary>
	public class ReqIconMerge : Request, IReqSingle {
		/// <summary>
		/// Parameters given to create or update a <see cref="Icon"/>.
		/// </summary>
		public ParamIconMerge icon { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.icon?.id?.ToString() ?? "";
	}
}