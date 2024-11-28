using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the details of the <see cref="Machine"/> requested.
	/// </summary>
	public class SelfMachine : Machine {
		/// <summary>
		/// A list of groups to which this machine account belongs.
		/// </summary>
		/// <seealso cref="UserGroup.id" />
		new public UserGroup[] groups { get; set; }
	}
}