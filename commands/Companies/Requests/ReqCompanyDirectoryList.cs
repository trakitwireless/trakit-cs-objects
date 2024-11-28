using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets a list of <see cref="CompanyDirectory"/>s.
	/// </summary>
	public abstract class ReqCompanyDirectoryList : Request, IReqIDeletable {
		/// <summary>
		/// When true, the command will also return a deleted <see cref="CompanyDirectory"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}

	/// <summary>
	/// Gets the list of <see cref="CompanyDirectory"/>s for the specified <see cref="Company"/>.
	/// </summary>
	public class ReqCompanyDirectoryListByCompany : ReqCompanyDirectoryList, IReqListByCompany {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ParamId company { get; set; }
	}
	/// <summary>
	/// Gets the list of <see cref="CompanyDirectory"/>s for the specified <see cref="Company"/> only if the <see cref="CompanyDirectoryDirectory.labels"/> matches all of the given <see cref="Parameters.labels"/>.
	/// </summary>
	public class ReqCompanyDirectoryListByCompanyAndLabels : ReqCompanyDirectoryListByCompany, IReqListByLabels {
		/// <summary>
		/// The parsed labels given as input.
		/// </summary>
		/// <seealso cref="CompanyDirectory.labels"/>
		public List<string> labels { get; set; }
	}
	/// <summary>
	/// Gets the list of <see cref="CompanyDirectory"/>s for the specified <see cref="Company"/> only if one of the specified <see cref="CompanyDirectoryDirectory.references"/> fields match.
	/// If no references are specified, it will match any <see cref="CompanyDirectory"/> with no references.
	/// If a reference value is null, it will match any <see cref="CompanyDirectory"/> without that reference key.
	/// </summary>
	public class ReqCompanyDirectoryListByCompanyAndRefPairs : ReqCompanyDirectoryListByCompany, IReqListByReferences {
		/// <summary>
		/// The parsed references given as input.
		/// </summary>
		/// <seealso cref="CompanyDirectoryDirectory.references"/>
		public Dictionary<string, string> references { get; set; }
	}
}