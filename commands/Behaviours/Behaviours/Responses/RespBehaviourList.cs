using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="behaviours"/>.
	/// </summary>
	public abstract class RespBehaviourList : Response {
		/// <summary>
		/// The list of requested <see cref="Behaviour"/>s.
		/// </summary>
		public Behaviour[] behaviours;
	}

	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class RespBehaviourListByCompany : RespBehaviourList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public RespId company;
	}
}