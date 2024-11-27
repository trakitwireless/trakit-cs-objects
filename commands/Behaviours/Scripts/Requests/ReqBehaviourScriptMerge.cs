using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Creates a new or updates an existing <see cref="BehaviourScript"/>.
	/// </summary>
	public class ReqBehaviourScriptMerge : Request, IReqSingle {
		/// <summary>
		/// Parameters given to create or update a <see cref="BehaviourScript"/>.
		/// </summary>
		public ParamBehaviourScriptMerge behaviourScript { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.behaviourScript?.id?.ToString() ?? "";
	}
}