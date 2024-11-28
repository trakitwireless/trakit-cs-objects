using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="companyResellers"/>.
	/// </summary>
	public abstract class RespCompanyResellerList : Response {
		/// <summary>
		/// The list of requested <see cref="CompanyReseller"/>s.
		/// </summary>
		public CompanyReseller[] companyResellers;
	}

	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RespCompanyResellerListByCompany : RespCompanyResellerList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public RespId company;
	}
	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RespCompanyResellerListByCompanyAndLabels : RespCompanyResellerListByCompany {
		/// <summary>
		/// The labels given as input.
		/// </summary>
		/// <seealso cref="CompanyReseller.labels"/>
		public string[] labels;
	}
	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RespCompanyResellerListByCompanyAndRefPairs : RespCompanyResellerListByCompany {
		/// <summary>
		/// The reference string given as input.
		/// </summary>
		/// <seealso cref="CompanyReseller.references"/>
		public Dictionary<string, string> references;
	}
}