using System;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="providerConfigurationType"/>.
	/// </summary>
	[Obsolete("Use ReqProviderScriptList instead")]
	public abstract class ReqProviderConfigurationTypeList : Request, IReqIDeletable {
		/// <summary>
		/// When true, the command will also return  deleted <see cref="ProviderConfigurationType"/>s.
		/// </summary>
		public bool includeDeleted { get; set; }
	}
	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	[Obsolete("Use ReqProviderScriptListByCompany instead")]
	public class ReqProviderConfigurationTypeListByCompany : ReqProviderConfigurationTypeList, IReqListByCompany {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ParamId company { get; set; }
	}
}