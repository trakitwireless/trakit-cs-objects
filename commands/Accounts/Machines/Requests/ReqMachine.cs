using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="machine"/> object.
	/// </summary>
	public abstract class ReqMachine : Request, IReqSingle {
		/// <summary>
		/// An object to contain the "id" of the <see cref="Machine"/>.
		/// </summary>
		public ParamKey machine { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.machine?.key ?? "";
	}
}