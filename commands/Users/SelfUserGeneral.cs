using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Similar to the <see cref="UserGeneral"/> object, but instead of the <see cref="contact"/> being an identifier,
	/// it is a <see cref="Contact"/> object.
	/// </summary>
	public class SelfUserGeneral : UserGeneral {
		/// <summary>
		/// Associated contact information for this user.
		/// </summary>
		new public Contact contact;
	}
}