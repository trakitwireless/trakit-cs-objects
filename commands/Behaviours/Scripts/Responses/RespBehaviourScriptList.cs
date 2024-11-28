using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="behaviourScripts"/>.
	/// </summary>
	public abstract class RespBehaviourScriptList : Response {
		/// <summary>
		/// The list of requested <see cref="BehaviourScript"/>s.
		/// </summary>
		public BehaviourScript[] behaviourScripts;
	}

	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class RespBehaviourScriptListByCompany : RespBehaviourScriptList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public RespId company;
	}
}