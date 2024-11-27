using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="place"/>.
	/// </summary>
	public class RespPlaceGet : Response {
		/// <summary>
		/// The requested <see cref="Place"/>.
		/// </summary>
		public Place place;
	}
}