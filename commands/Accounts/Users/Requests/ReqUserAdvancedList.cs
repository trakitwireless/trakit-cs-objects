using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets a list of <see cref="UserAdvanced"/>s.
	/// </summary>
	public abstract class ReqUserAdvancedList : Request, IReqIDeletable {
		/// <summary>
		/// When true, the command will also return a deleted <see cref="UserAdvanced"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}

	/// <summary>
	/// Gets the list of <see cref="UserAdvanced"/>s for the specified <see cref="Company"/>.
	/// </summary>
	public class ReqUserAdvancedListByCompany : ReqUserAdvancedList, IReqListByCompany {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ParamId company { get; set; }
	}
	/// <summary>
	/// Gets the list of <see cref="UserAdvanced"/>s for the specified <see cref="Company"/> only if the <see cref="UserAdvancedGeneral.labels"/> matches all of the given <see cref="Parameters.labels"/>.
	/// </summary>
	public class ReqUserAdvancedListByCompanyAndLabels : ReqUserAdvancedListByCompany, IReqListByLabels {
		/// <summary>
		/// The parsed labels given as input.
		/// </summary>
		/// <seealso cref="UserGeneral.labels"/>
		public List<string> labels { get; set; }
	}
	/// <summary>
	/// Gets the list of <see cref="UserAdvanced"/>s for the specified <see cref="Company"/> only if one of the specified <see cref="UserAdvancedGeneral.references"/> fields match.
	/// If no references are specified, it will match any <see cref="UserAdvanced"/> with no references.
	/// If a reference value is null, it will match any <see cref="UserAdvanced"/> without that reference key.
	/// </summary>
	public class ReqUserAdvancedListByCompanyAndRefPairs : ReqUserAdvancedListByCompany, IReqListByReferences {
		/// <summary>
		/// The parsed references given as input.
		/// </summary>
		/// <seealso cref="UserAdvancedGeneral.references"/>
		public Dictionary<string, string> references { get; set; }
	}
}