using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Creates a new or updates an existing <see cref="BillableHostingRule"/>.
	/// </summary>
	public class ReqBillableHostingRuleMerge : Request, IReqSingle {
		/// <summary>
		/// Parameters given to create or update a <see cref="BillableHostingRule"/>.
		/// </summary>
		public ParamBillableHostingRuleMerge hostingRule { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.hostingRule?.id?.ToString() ?? "";
	}
}