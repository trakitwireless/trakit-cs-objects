using System;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="providerConfiguration"/>.
	/// </summary>
	[Obsolete("Use ReqProviderConfigList instead")]
	public abstract class ReqProviderConfigurationList : Request, IReqIDeletable {
		/// <summary>
		/// When true, the command will also return  deleted <see cref="ProviderConfiguration"/>s.
		/// </summary>
		public bool includeDeleted { get; set; }
	}
	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	[Obsolete("Use ReqProviderConfigListByCompany instead")]
	public class ReqProviderConfigurationListByCompany : ReqProviderConfigurationList, IReqListByCompany {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ParamId company { get; set; }
	}
}