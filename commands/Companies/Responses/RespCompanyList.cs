using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="companies"/>.
	/// </summary>
	public abstract class RespCompanyList : Response {
		/// <summary>
		/// The list of requested <see cref="Company"/>s.
		/// </summary>
		public Company[] companies;
	}

	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class RespCompanyListByCompany : RespCompanyList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public RespId company;
	}
	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class RespCompanyListByCompanyAndRefPairs : RespCompanyListByCompany, IReqListByReferences {
		/// <summary>
		/// The parsed references given as input.
		/// </summary>
		/// <seealso cref="CompanyGeneral.references"/>
		public Dictionary<string, string> references { get; set; }
	}
}