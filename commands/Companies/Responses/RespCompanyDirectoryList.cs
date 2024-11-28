using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="companyDirectorys"/>.
	/// </summary>
	public abstract class RespCompanyDirectoryList : Response {
		/// <summary>
		/// The list of requested <see cref="CompanyDirectory"/>s.
		/// </summary>
		public CompanyDirectory[] companyDirectorys;
	}

	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RespCompanyDirectoryListByCompany : RespCompanyDirectoryList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public RespId company;
	}
	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RespCompanyDirectoryListByCompanyAndLabels : RespCompanyDirectoryListByCompany {
		/// <summary>
		/// The labels given as input.
		/// </summary>
		/// <seealso cref="CompanyDirectory.labels"/>
		public string[] labels;
	}
	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RespCompanyDirectoryListByCompanyAndRefPairs : RespCompanyDirectoryListByCompany {
		/// <summary>
		/// The reference string given as input.
		/// </summary>
		/// <seealso cref="CompanyDirectory.references"/>
		public Dictionary<string, string> references;
	}
}