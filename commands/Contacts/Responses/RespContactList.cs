using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="contacts"/>.
	/// </summary>
	public abstract class RespContactList : Response {
		/// <summary>
		/// The list of requested <see cref="Contact"/>s.
		/// </summary>
		public Contact[] contacts;
	}

	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class RespContactListByCompany : RespContactList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public RespId company;
	}
}