using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Creates a new or updates an existing <see cref="FormResult"/>.
	/// </summary>
	public class ReqFormResultMerge : Request, IReqSingle {
		/// <summary>
		/// Parameters given to create or update a <see cref="FormResult"/>.
		/// </summary>
		public ParamFormResultMerge formResult { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.formResult?.id?.ToString() ?? "";
	}
}