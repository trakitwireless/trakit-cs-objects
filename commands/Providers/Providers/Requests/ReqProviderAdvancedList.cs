using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets a list of <see cref="ProviderAdvanced"/>s.
	/// </summary>
	public abstract class ReqProviderAdvancedList : Request, IReqIDeletable, IReqISuspendable {
		/// <summary>
		/// When true, the command will also return suspended <see cref="ProviderAdvanced"/>s.
		/// </summary>
		public bool includeSuspended { get; set; }
		/// <summary>
		/// When true, the command will also return a deleted <see cref="ProviderAdvanced"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}

	/// <summary>
	/// Gets the list of <see cref="ProviderAdvanced"/>s for the specified <see cref="Company"/>.
	/// </summary>
	public class ReqProviderAdvancedListByCompany : ReqProviderAdvancedList, IReqListByCompany {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ParamId company { get; set; }
	}
	/// <summary>
	/// Gets the list of <see cref="ProviderAdvanced"/>s for the specified <see cref="Company"/> only if the <see cref="ProviderAdvancedGeneral.labels"/> matches all of the given <see cref="Parameters.labels"/>.
	/// </summary>
	public class ReqProviderAdvancedListByCompanyAndLabels : ReqProviderAdvancedListByCompany, IReqListByLabels {
		/// <summary>
		/// The parsed labels given as input.
		/// </summary>
		/// <seealso cref="ProviderGeneral.labels"/>
		public List<string> labels { get; set; }
	}
	/// <summary>
	/// Gets the list of <see cref="ProviderAdvanced"/>s for the specified <see cref="Company"/> only if one of the specified <see cref="ProviderAdvancedGeneral.references"/> fields match.
	/// If no references are specified, it will match any <see cref="ProviderAdvanced"/> with no references.
	/// If a reference value is null, it will match any <see cref="ProviderAdvanced"/> without that reference key.
	/// </summary>
	public class ReqProviderAdvancedListByCompanyAndRefPairs : ReqProviderAdvancedListByCompany, IReqListByReferences {
		/// <summary>
		/// The parsed references given as input.
		/// </summary>
		/// <seealso cref="ProviderAdvancedGeneral.references"/>
		public Dictionary<string, string> references { get; set; }
	}
}