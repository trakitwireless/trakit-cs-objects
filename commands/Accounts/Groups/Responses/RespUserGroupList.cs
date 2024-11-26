using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="userGroups"/>.
	/// </summary>
	public abstract class RespUserGroupList : Response {
		/// <summary>
		/// The list of requested <see cref="UserGroup"/>s.
		/// </summary>
		public UserGroup[] userGroups;
	}

	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class RespUserGroupListByCompany : RespUserGroupList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public RespId company;
	}
}