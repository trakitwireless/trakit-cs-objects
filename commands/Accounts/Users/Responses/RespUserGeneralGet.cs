using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="userGeneral"/>.
	/// </summary>
	public class RespUserGeneralGet : Response {
		/// <summary>
		/// The requested <see cref="User"/>.
		/// </summary>
		public UserGeneral userGeneral;
	}
}