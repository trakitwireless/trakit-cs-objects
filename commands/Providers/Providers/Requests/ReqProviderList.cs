using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="provider"/>.
	/// </summary>
	public abstract class ReqProviderList : Request, IReqIDeletable {
		/// <summary>
		/// When true, the command will also return  deleted <see cref="Provider"/>s.
		/// </summary>
		public bool includeDeleted { get; set; }
	}
	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class ReqProviderListByCompany : ReqProviderList, IReqListByCompany {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ParamId company { get; set; }
	}
}