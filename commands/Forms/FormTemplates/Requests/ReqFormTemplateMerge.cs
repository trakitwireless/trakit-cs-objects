using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Creates a new or updates an existing <see cref="FormTemplate"/>.
	/// </summary>
	public class ReqFormTemplateMerge : Request, IReqSingle {
		/// <summary>
		/// Parameters given to create or update a <see cref="FormTemplate"/>.
		/// </summary>
		public ParamFormTemplateMerge formTemplate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.formTemplate?.id?.ToString() ?? "";
	}
}