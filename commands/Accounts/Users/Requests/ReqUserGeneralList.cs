using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets a list of <see cref="UserGeneral"/>s.
	/// </summary>
	public abstract class ReqUserGeneralList : Request, IReqIDeletable {
		/// <summary>
		/// When true, the command will also return a deleted <see cref="UserGeneral"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}

	/// <summary>
	/// Gets the list of <see cref="UserGeneral"/>s for the specified <see cref="Company"/>.
	/// </summary>
	public class ReqUserGeneralListByCompany : ReqUserGeneralList, IReqListByCompany {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ParamId company { get; set; }
	}
	/// <summary>
	/// Gets the list of <see cref="UserGeneral"/>s for the specified <see cref="Company"/> only if the <see cref="UserGeneralGeneral.labels"/> matches all of the given <see cref="Parameters.labels"/>.
	/// </summary>
	public class ReqUserGeneralListByCompanyAndLabels : ReqUserGeneralListByCompany, IReqListByLabels {
		/// <summary>
		/// The parsed labels given as input.
		/// </summary>
		/// <seealso cref="UserGeneral.labels"/>
		public List<string> labels { get; set; }
	}
	/// <summary>
	/// Gets the list of <see cref="UserGeneral"/>s for the specified <see cref="Company"/> only if one of the specified <see cref="UserGeneralGeneral.references"/> fields match.
	/// If no references are specified, it will match any <see cref="UserGeneral"/> with no references.
	/// If a reference value is null, it will match any <see cref="UserGeneral"/> without that reference key.
	/// </summary>
	public class ReqUserGeneralListByCompanyAndRefPairs : ReqUserGeneralListByCompany, IReqListByReferences {
		/// <summary>
		/// The parsed references given as input.
		/// </summary>
		/// <seealso cref="UserGeneralGeneral.references"/>
		public Dictionary<string, string> references { get; set; }
	}
}