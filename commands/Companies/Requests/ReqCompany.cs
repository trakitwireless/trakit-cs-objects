using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="company"/> object.
	/// </summary>
	public abstract class ReqCompany : Request, IReqSingle {
		/// <summary>
		/// An object to contain the "id" of the <see cref="Company"/>.
		/// </summary>
		public ParamId company { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.company?.id.ToString() ?? "";
	}
}