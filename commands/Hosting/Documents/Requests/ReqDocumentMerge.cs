using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Creates a new or updates an existing <see cref="Document"/>.
	/// </summary>
	public class ReqDocumentMerge : Request, IReqSingle {
		/// <summary>
		/// Parameters given to create or update a <see cref="Document"/>.
		/// </summary>
		public ParamDocumentMerge document { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.document?.id?.ToString() ?? "";
	}
}