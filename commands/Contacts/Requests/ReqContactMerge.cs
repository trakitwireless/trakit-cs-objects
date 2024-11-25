using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Creates a new or updates an existing <see cref="Contact"/>.
	/// </summary>
	public class ReqContactMerge : Request, IReqSingle {
		/// <summary>
		/// Parameters given to create or update a <see cref="Contact"/>.
		/// </summary>
		public ParamContactMerge contact { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.contact?.id?.ToString() ?? "";
	}
}