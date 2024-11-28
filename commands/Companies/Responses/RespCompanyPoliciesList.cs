using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="companyPolicies"/>.
	/// </summary>
	public abstract class RespCompanyPoliciesList : Response {
		/// <summary>
		/// The list of requested <see cref="CompanyPolicies"/>s.
		/// </summary>
		public CompanyPolicies[] companyPolicies;
	}

	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RespCompanyPoliciesListByCompany : RespCompanyPoliciesList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public RespId company;
	}
	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RespCompanyPoliciesListByCompanyAndLabels : RespCompanyPoliciesListByCompany {
		/// <summary>
		/// The labels given as input.
		/// </summary>
		/// <seealso cref="CompanyPolicies.labels"/>
		public string[] labels;
	}
	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RespCompanyPoliciesListByCompanyAndRefPairs : RespCompanyPoliciesListByCompany {
		/// <summary>
		/// The reference string given as input.
		/// </summary>
		/// <seealso cref="CompanyPolicies.references"/>
		public Dictionary<string, string> references;
	}
}