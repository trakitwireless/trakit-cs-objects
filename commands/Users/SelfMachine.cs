using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the details of the <see cref="Machine"/> requested.
	/// </summary>
	public class SelfMachine : Machine {
		/// <summary>
		/// The list of <see cref="UserGroup"/> to which this <see cref="User"/> belongs.
		/// </summary>
		new public UserGroup[] groups;
	}
}