using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="contact"/> object.
	/// </summary>
	public abstract class ReqContact : IReqSingle {
		/// <summary>
		/// An object to contain the "id" of the <see cref="Contact"/>.
		/// </summary>
		public ParamId contact { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.contact?.id.ToString() ?? "";
	}
}