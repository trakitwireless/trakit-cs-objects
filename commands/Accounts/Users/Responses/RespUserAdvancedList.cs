using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="userAdvanceds"/>.
	/// </summary>
	public abstract class RespUserAdvancedList : Response {
		/// <summary>
		/// The list of requested <see cref="UserAdvanced"/>s.
		/// </summary>
		public UserAdvanced[] userAdvanceds;
	}

	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RespUserAdvancedListByCompany : RespUserAdvancedList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public RespId company;
	}
	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RespUserAdvancedListByCompanyAndLabels : RespUserAdvancedListByCompany {
		/// <summary>
		/// The labels given as input.
		/// </summary>
		/// <seealso cref="UserGeneral.labels"/>
		public string[] labels;
	}
	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RespUserAdvancedListByCompanyAndRefPairs : RespUserAdvancedListByCompany {
		/// <summary>
		/// The reference string given as input.
		/// </summary>
		/// <seealso cref="UserGeneral.references"/>
		public Dictionary<string, string> references;
	}
}