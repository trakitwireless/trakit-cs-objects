using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets a list of <see cref="CompanyPolicies"/>s.
	/// </summary>
	public abstract class ReqCompanyPoliciesList : Request, IReqIDeletable {
		/// <summary>
		/// When true, the command will also return a deleted <see cref="CompanyPolicies"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}

	/// <summary>
	/// Gets the list of <see cref="CompanyPolicies"/>s for the specified <see cref="Company"/>.
	/// </summary>
	public class ReqCompanyPoliciesListByCompany : ReqCompanyPoliciesList, IReqListByCompany {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ParamId company { get; set; }
	}
	/// <summary>
	/// Gets the list of <see cref="CompanyPolicies"/>s for the specified <see cref="Company"/> only if the <see cref="CompanyPoliciesPolicies.labels"/> matches all of the given <see cref="Parameters.labels"/>.
	/// </summary>
	public class ReqCompanyPoliciesListByCompanyAndLabels : ReqCompanyPoliciesListByCompany, IReqListByLabels {
		/// <summary>
		/// The parsed labels given as input.
		/// </summary>
		/// <seealso cref="CompanyPolicies.labels"/>
		public List<string> labels { get; set; }
	}
	/// <summary>
	/// Gets the list of <see cref="CompanyPolicies"/>s for the specified <see cref="Company"/> only if one of the specified <see cref="CompanyPoliciesPolicies.references"/> fields match.
	/// If no references are specified, it will match any <see cref="CompanyPolicies"/> with no references.
	/// If a reference value is null, it will match any <see cref="CompanyPolicies"/> without that reference key.
	/// </summary>
	public class ReqCompanyPoliciesListByCompanyAndRefPairs : ReqCompanyPoliciesListByCompany, IReqListByReferences {
		/// <summary>
		/// The parsed references given as input.
		/// </summary>
		/// <seealso cref="CompanyPoliciesPolicies.references"/>
		public Dictionary<string, string> references { get; set; }
	}
}