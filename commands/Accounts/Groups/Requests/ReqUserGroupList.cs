using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="userGroup"/>.
	/// </summary>
	public abstract class ReqUserGroupList : Request, IReqIDeletable {
		/// <summary>
		/// When true, the command will also return  deleted <see cref="UserGroup"/>s.
		/// </summary>
		public bool includeDeleted { get; set; }
	}
	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class ReqUserGroupListByCompany : ReqUserGroupList, IReqListByCompany {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ParamId company { get; set; }
	}
}