using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="picture"/>.
	/// </summary>
	public class RespPictureDelete : Response {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="Picture"/>.
		/// </summary>
		public RespDeleted picture;
	}
}