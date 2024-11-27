using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="formResult"/>.
	/// </summary>
	public abstract class ReqFormResultList : Request, IReqIDeletable {
		/// <summary>
		/// When true, the command will also return  deleted <see cref="FormResult"/>s.
		/// </summary>
		public bool includeDeleted { get; set; }
	}
	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class ReqFormResultListByCompany : ReqFormResultList, IReqListByCompany {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ParamId company { get; set; }
	}
}