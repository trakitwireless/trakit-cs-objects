using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="assetGenerals"/>.
	/// </summary>
	public abstract class RespAssetGeneralList : Response {
		/// <summary>
		/// The list of requested <see cref="AssetGeneral"/>s.
		/// </summary>
		public AssetGeneral[] assetGenerals;
	}

	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RespAssetGeneralListByCompany : RespAssetGeneralList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public RespId company;
	}
	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RespAssetGeneralListByCompanyAndLabels : RespAssetGeneralListByCompany {
		/// <summary>
		/// The labels given as input.
		/// </summary>
		/// <seealso cref="AssetGeneral.labels"/>
		public string[] labels;
	}
	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RespAssetGeneralListByCompanyAndRefPairs : RespAssetGeneralListByCompany {
		/// <summary>
		/// The reference string given as input.
		/// </summary>
		/// <seealso cref="AssetGeneral.references"/>
		public Dictionary<string, string> references;
	}
}