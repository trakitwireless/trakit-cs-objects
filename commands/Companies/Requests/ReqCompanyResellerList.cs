using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets a list of <see cref="CompanyReseller"/>s.
	/// </summary>
	public abstract class ReqCompanyResellerList : Request, IReqIDeletable {
		/// <summary>
		/// When true, the command will also return a deleted <see cref="CompanyReseller"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}

	/// <summary>
	/// Gets the list of <see cref="CompanyReseller"/>s for the specified <see cref="Company"/>.
	/// </summary>
	public class ReqCompanyResellerListByCompany : ReqCompanyResellerList, IReqListByCompany {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ParamId company { get; set; }
	}
	/// <summary>
	/// Gets the list of <see cref="CompanyReseller"/>s for the specified <see cref="Company"/> only if the <see cref="CompanyResellerReseller.labels"/> matches all of the given <see cref="Parameters.labels"/>.
	/// </summary>
	public class ReqCompanyResellerListByCompanyAndLabels : ReqCompanyResellerListByCompany, IReqListByLabels {
		/// <summary>
		/// The parsed labels given as input.
		/// </summary>
		/// <seealso cref="CompanyReseller.labels"/>
		public List<string> labels { get; set; }
	}
	/// <summary>
	/// Gets the list of <see cref="CompanyReseller"/>s for the specified <see cref="Company"/> only if one of the specified <see cref="CompanyResellerReseller.references"/> fields match.
	/// If no references are specified, it will match any <see cref="CompanyReseller"/> with no references.
	/// If a reference value is null, it will match any <see cref="CompanyReseller"/> without that reference key.
	/// </summary>
	public class ReqCompanyResellerListByCompanyAndRefPairs : ReqCompanyResellerListByCompany, IReqListByReferences {
		/// <summary>
		/// The parsed references given as input.
		/// </summary>
		/// <seealso cref="CompanyResellerReseller.references"/>
		public Dictionary<string, string> references { get; set; }
	}
}