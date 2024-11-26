using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="machines"/>.
	/// </summary>
	public abstract class RespMachineList : Response {
		/// <summary>
		/// The list of requested <see cref="Machine"/>s.
		/// </summary>
		public Machine[] machines;
	}

	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class RespMachineListByCompany : RespMachineList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public RespId company;
	}
}