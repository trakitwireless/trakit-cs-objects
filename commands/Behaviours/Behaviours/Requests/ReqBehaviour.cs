using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="behaviour"/> object.
	/// </summary>
	public abstract class ReqBehaviour : Request, IReqSingle {
		/// <summary>
		/// An object to contain the "id" of the <see cref="Behaviour"/>.
		/// </summary>
		public ParamId behaviour { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.behaviour?.id.ToString() ?? "";
	}
}