using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="sessions"/>.
	/// </summary>
	public abstract class RespSessionList : Response {
		/// <summary>
		/// The list of requested <see cref="SessionDetails"/>.
		/// </summary>
		public SessionDetails[] sessions;
	}

	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public abstract class RespSessionListByCompany : RespSessionList {
		/// <summary>
		/// An object to contain the "id" of the <see cref="Company"/> to which the array of <see cref="SessionDetails"/>s belong.
		/// </summary>
		public RespId company;
	}
	/// <summary>
	/// Contains the <see cref="User.login"/> of the collection.
	/// </summary>
	public abstract class RespSessionListByUser : RespSessionList {
		/// <summary>
		/// An object to contain the "login" of the <see cref="User"/> to which the array of <see cref="SessionDetails"/>s belong.
		/// </summary>
		public RespLoginCompany user;
	}
}