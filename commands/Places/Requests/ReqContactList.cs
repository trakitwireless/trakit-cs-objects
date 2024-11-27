using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="place"/>.
	/// </summary>
	public abstract class ReqPlaceList : Request, IReqIDeletable {
		/// <summary>
		/// When true, the command will also return  deleted <see cref="Place"/>s.
		/// </summary>
		public bool includeDeleted { get; set; }
	}
	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class ReqPlaceListByCompany : ReqPlaceList, IReqListByCompany {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ParamId company { get; set; }
	}
}