using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="userAdvanced"/>.
	/// </summary>
	public class RespUserAdvancedGet : Response {
		/// <summary>
		/// The requested <see cref="UserAdvanced"/>.
		/// </summary>
		public UserAdvanced userAdvanced;
	}
}