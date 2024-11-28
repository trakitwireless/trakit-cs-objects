using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="picture"/>.
	/// </summary>
	public class RespPictureGet : Response {
		/// <summary>
		/// The requested <see cref="Picture"/>.
		/// </summary>
		public Picture picture;
	}
}