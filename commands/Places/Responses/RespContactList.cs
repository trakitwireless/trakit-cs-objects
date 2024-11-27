using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="places"/>.
	/// </summary>
	public abstract class RespPlaceList : Response {
		/// <summary>
		/// The list of requested <see cref="Place"/>s.
		/// </summary>
		public Place[] places;
	}

	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class RespPlaceListByCompany : RespPlaceList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public RespId company;
	}
}