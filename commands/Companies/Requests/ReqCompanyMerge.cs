using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Creates a new or updates an existing <see cref="Company"/>.
	/// </summary>
	public class ReqCompanyMerge : Request, IReqSingle {
		/// <summary>
		/// Parameters given to create or update a <see cref="Company"/>.
		/// </summary>
		public ParamCompanyMerge company { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.company?.id?.ToString() ?? "";
	}
}