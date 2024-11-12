using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="assetAdvanceds"/>.
	/// </summary>
	public abstract class RespAssetAdvancedList : Response {
		/// <summary>
		/// The list of requested <see cref="AssetAdvanced"/>s.
		/// </summary>
		public AssetAdvanced[] assetAdvanceds;
	}

	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RespAssetAdvancedListByCompany : RespAssetAdvancedList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public RespId company;
	}
	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RespAssetAdvancedListByCompanyAndLabels : RespAssetAdvancedListByCompany {
		/// <summary>
		/// The labels given as input.
		/// </summary>
		/// <seealso cref="AssetGeneral.labels"/>
		public string[] labels;
	}
	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RespAssetAdvancedListByCompanyAndRefPairs : RespAssetAdvancedListByCompany {
		/// <summary>
		/// The reference string given as input.
		/// </summary>
		/// <seealso cref="AssetGeneral.references"/>
		public Dictionary<string, string> references;
	}
}