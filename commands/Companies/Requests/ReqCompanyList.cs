using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="company"/>.
	/// </summary>
	public abstract class ReqCompanyList : Request, IReqIDeletable {
		/// <summary>
		/// When set to true, the full tree of <see cref="Company">companies</see> is returned.
		/// Otherwise, only the first-level child-<see cref="Company">companies</see> are included.
		/// </summary>
		public bool tree;
		/// <summary>
		/// When set to true, the parent <see cref="Company"/> is included in the results.
		/// </summary>
		public bool includeParent;
		/// <summary>
		/// When true, the command will also return  deleted <see cref="Company"/>s.
		/// </summary>
		public bool includeDeleted { get; set; }
	}
	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class ReqCompanyListByCompany : ReqCompanyList, IReqListByCompany {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ParamId company { get; set; }
	}
	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class ReqCompanyListByCompanyAndRefPairs : ReqCompanyListByCompany, IReqListByReferences {
		/// <summary>
		/// Case-insensitive reference pairs used to match <see cref="Company"/>s.
		/// </summary>
		/// <seealso cref="CompanyGeneral.references"/>
		public Dictionary<string, string> references { get; set; }
	}
}