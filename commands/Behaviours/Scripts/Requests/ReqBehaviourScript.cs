using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="behaviourScript"/> object.
	/// </summary>
	public abstract class ReqBehaviourScript : Request, IReqSingle {
		/// <summary>
		/// An object to contain the "id" of the <see cref="BehaviourScript"/>.
		/// </summary>
		public ParamId behaviourScript { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.behaviourScript?.id.ToString() ?? "";
	}
}