using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="hostingRule"/> object.
	/// </summary>
	public abstract class ReqBillableHostingRule : Request, IReqSingle {
		/// <summary>
		/// An object to contain the "id" of the <see cref="BillableHostingRule"/>.
		/// </summary>
		public ParamId hostingRule { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.hostingRule?.id.ToString() ?? "";
	}
}