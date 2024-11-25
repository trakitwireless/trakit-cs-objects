using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="assets"/>.
	/// </summary>
	public abstract class RespAssetList : Response {
		/// <summary>
		/// The list of requested <see cref="Asset"/>s.
		/// </summary>
		public Asset[] assets;
	}

	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class RespAssetListByCompany : RespAssetList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public RespId company;
	}
	/// <summary>
	/// Contains the codified <see cref="Company.labels"/> keys used to filter the collection.
	/// </summary>
	public class RespAssetListByCompanyAndLabels : RespAssetListByCompany {
		/// <summary>
		/// The parsed labels given as input.
		/// </summary>
		/// <seealso cref="AssetGeneral.labels"/>
		public string[] labels;
	}
	/// <summary>
	/// Contains the <see cref="AssetGeneral.references"/> used to filter the collection.
	/// </summary>
	public class RespAssetListByCompanyAndRefPairs : RespAssetListByCompany {
		/// <summary>
		/// The parsed references given as input.
		/// </summary>
		/// <seealso cref="AssetGeneral.references"/>
		public Dictionary<string, string> references;
	}

}