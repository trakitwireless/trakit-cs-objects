using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="contact"/>.
	/// </summary>
	public class ReqContactMerge : Request, IReqSingle {
		/// <summary>
		/// An object to contain the "id" of the <see cref="Contact"/>.
		/// </summary>
		public ParamContactMerge contact { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.contact?.id?.ToString() ?? "";
	}
}