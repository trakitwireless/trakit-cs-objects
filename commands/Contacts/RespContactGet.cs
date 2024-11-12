using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="contact"/>.
	/// </summary>
	public class RespContactGet : Response {
		/// <summary>
		/// The requested <see cref="Contact"/>.
		/// </summary>
		public Contact contact;
	}
}