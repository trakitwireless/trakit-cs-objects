using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets a list of <see cref="ProviderGeneral"/>s.
	/// </summary>
	public abstract class ReqProviderGeneralList : Request, IReqIDeletable, IReqISuspendable {
		/// <summary>
		/// When true, the command will also return <see cref="ProviderGeneralMessage"/>s for the asset.
		/// </summary>
		public bool includeMessages { get; set; }
		/// <summary>
		/// When true, the command will also return <see cref="DispatchTask"/>s for the asset.
		/// </summary>
		public bool includeTasks { get; set; }
		/// <summary>
		/// When true, the command will also return suspended <see cref="ProviderGeneral"/>s.
		/// </summary>
		public bool includeSuspended { get; set; }
		/// <summary>
		/// When true, the command will also return a deleted <see cref="ProviderGeneral"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}

	/// <summary>
	/// Gets the list of <see cref="ProviderGeneral"/>s for the specified <see cref="Company"/>.
	/// </summary>
	public class ReqProviderGeneralListByCompany : ReqProviderGeneralList, IReqListByCompany {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ParamId company { get; set; }
	}
	/// <summary>
	/// Gets the list of <see cref="ProviderGeneral"/>s for the specified <see cref="Company"/> only if the <see cref="ProviderGeneralGeneral.labels"/> matches all of the given <see cref="Parameters.labels"/>.
	/// </summary>
	public class ReqProviderGeneralListByCompanyAndLabels : ReqProviderGeneralListByCompany, IReqListByLabels {
		/// <summary>
		/// The parsed labels given as input.
		/// </summary>
		/// <seealso cref="ProviderGeneral.labels"/>
		public List<string> labels { get; set; }
	}
	/// <summary>
	/// Gets the list of <see cref="ProviderGeneral"/>s for the specified <see cref="Company"/> only if one of the specified <see cref="ProviderGeneralGeneral.references"/> fields match.
	/// If no references are specified, it will match any <see cref="ProviderGeneral"/> with no references.
	/// If a reference value is null, it will match any <see cref="ProviderGeneral"/> without that reference key.
	/// </summary>
	public class ReqProviderGeneralListByCompanyAndRefPairs : ReqProviderGeneralListByCompany, IReqListByReferences {
		/// <summary>
		/// The parsed references given as input.
		/// </summary>
		/// <seealso cref="ProviderGeneralGeneral.references"/>
		public Dictionary<string, string> references { get; set; }
	}
}