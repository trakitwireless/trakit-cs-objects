using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="assetDispatches"/>.
	/// </summary>
	public abstract class RespAssetDispatchList : Response {
		/// <summary>
		/// The list of requested <see cref="AssetDispatch"/>es.
		/// </summary>
		public AssetDispatch[] assetDispatches;
	}

	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RespAssetDispatchListByCompany : RespAssetDispatchList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public RespId company;
	}
	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RespAssetDispatchListByCompanyAndLabels : RespAssetDispatchListByCompany {
		/// <summary>
		/// The labels given as input.
		/// </summary>
		/// <seealso cref="AssetGeneral.labels"/>
		public string[] labels;
	}
	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RespAssetDispatchListByCompanyAndRefPairs : RespAssetDispatchListByCompany {
		/// <summary>
		/// The reference string given as input.
		/// </summary>
		/// <seealso cref="AssetGeneral.references"/>
		public Dictionary<string, string> references;
	}
}