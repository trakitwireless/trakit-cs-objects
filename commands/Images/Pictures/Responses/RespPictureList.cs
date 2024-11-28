using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="pictures"/>.
	/// </summary>
	public abstract class RespPictureList : Response {
		/// <summary>
		/// The list of requested <see cref="Picture"/>s.
		/// </summary>
		public Picture[] pictures;
	}

	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class RespPictureListByCompany : RespPictureList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public RespId company;
	}
}