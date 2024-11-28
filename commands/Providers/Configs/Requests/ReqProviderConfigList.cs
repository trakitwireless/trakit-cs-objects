using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="providerConfig"/>.
	/// </summary>
	public abstract class ReqProviderConfigList : Request, IReqIDeletable {
		/// <summary>
		/// When true, the command will also return  deleted <see cref="ProviderConfig"/>s.
		/// </summary>
		public bool includeDeleted { get; set; }
	}
	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class ReqProviderConfigListByCompany : ReqProviderConfigList, IReqListByCompany {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ParamId company { get; set; }
	}
}