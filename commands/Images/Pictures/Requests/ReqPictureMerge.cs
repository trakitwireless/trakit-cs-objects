using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Creates a new or updates an existing <see cref="Picture"/>.
	/// </summary>
	public class ReqPictureMerge : Request, IReqSingle {
		/// <summary>
		/// Parameters given to create or update a <see cref="Picture"/>.
		/// </summary>
		public ParamPictureMerge picture { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.picture?.id?.ToString() ?? "";
	}
}