using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="picture"/>.
	/// </summary>
	public class RespPictureBatchDelete : Response {
		/// <summary>
		/// Details about deleting/restoring the requested <see cref="Picture"/>.
		/// </summary>
		public RespIdDeleted[] pictures;
	}
}