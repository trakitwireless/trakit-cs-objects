using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets a list of <see cref="CompanyGeneral"/>s.
	/// </summary>
	public abstract class ReqCompanyGeneralList : Request, IReqIDeletable {
		/// <summary>
		/// When true, the command will also return a deleted <see cref="CompanyGeneral"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}

	/// <summary>
	/// Gets the list of <see cref="CompanyGeneral"/>s for the specified <see cref="Company"/>.
	/// </summary>
	public class ReqCompanyGeneralListByCompany : ReqCompanyGeneralList, IReqListByCompany {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ParamId company { get; set; }
	}
	/// <summary>
	/// Gets the list of <see cref="CompanyGeneral"/>s for the specified <see cref="Company"/> only if the <see cref="CompanyGeneral.labels"/> matches all of the given <see cref="CompanyStyles.labels"/>.
	/// </summary>
	public class ReqCompanyGeneralListByCompanyAndLabels : ReqCompanyGeneralListByCompany, IReqListByLabels {
		/// <summary>
		/// The parsed labels given as input.
		/// </summary>
		/// <seealso cref="CompanyStyles.labels"/>
		public List<string> labels { get; set; }
	}
	/// <summary>
	/// Gets the list of <see cref="CompanyGeneral"/>s for the specified <see cref="Company"/> only if one of the specified <see cref="CompanyGeneral.references"/> fields match.
	/// If no references are specified, it will match any <see cref="CompanyGeneral"/> with no references.
	/// If a reference value is null, it will match any <see cref="CompanyGeneral"/> without that reference key.
	/// </summary>
	public class ReqCompanyGeneralListByCompanyAndRefPairs : ReqCompanyGeneralListByCompany, IReqListByReferences {
		/// <summary>
		/// The parsed references given as input.
		/// </summary>
		/// <seealso cref="CompanyGeneralGeneral.references"/>
		public Dictionary<string, string> references { get; set; }
	}
}