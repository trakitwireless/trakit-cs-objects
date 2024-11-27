using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Creates a new or updates an existing <see cref="Place"/>.
	/// </summary>
	public class ReqPlaceMerge : Request, IReqSingle {
		/// <summary>
		/// Parameters given to create or update a <see cref="Place"/>.
		/// </summary>
		public ParamPlaceMerge place { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.place?.id?.ToString() ?? "";
	}
}