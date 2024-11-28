using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="companyGenerals"/>.
	/// </summary>
	public abstract class RespCompanyGeneralList : Response {
		/// <summary>
		/// The list of requested <see cref="CompanyGeneral"/>s.
		/// </summary>
		public CompanyGeneral[] companyGenerals;
	}

	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RespCompanyGeneralListByCompany : RespCompanyGeneralList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public RespId company;
	}
	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RespCompanyGeneralListByCompanyAndLabels : RespCompanyGeneralListByCompany {
		/// <summary>
		/// The labels given as input.
		/// </summary>
		/// <seealso cref="CompanyGeneral.labels"/>
		public string[] labels;
	}
	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RespCompanyGeneralListByCompanyAndRefPairs : RespCompanyGeneralListByCompany {
		/// <summary>
		/// The reference string given as input.
		/// </summary>
		/// <seealso cref="CompanyGeneral.references"/>
		public Dictionary<string, string> references;
	}
}