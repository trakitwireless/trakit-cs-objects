using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets a list of <see cref="Asset"/>s.
	/// </summary>
	public abstract class ReqAssetList : Request, IReqIDeletable, IReqISuspendable {
		/// <summary>
		/// When true, the command will also return <see cref="Message"/>s for the asset.
		/// </summary>
		public bool includeMessages { get; set; }
		/// <summary>
		/// When true, the command will also return <see cref="DispatchTask"/>s for the asset.
		/// </summary>
		public bool includeTasks { get; set; }
		/// <summary>
		/// When true, the command will also return suspended <see cref="Asset"/>s.
		/// </summary>
		public bool includeSuspended { get; set; }
		/// <summary>
		/// When true, the command will also return a deleted <see cref="Asset"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}

	/// <summary>
	/// Gets the list of <see cref="Asset"/>s for the specified <see cref="Company"/>.
	/// </summary>
	public class ReqAssetListByCompany : ReqAssetList, IReqListByCompany {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ParamId company { get; set; }
	}
	/// <summary>
	/// Gets the list of <see cref="Asset"/>s for the specified <see cref="Company"/> only if the <see cref="AssetGeneral.labels"/> matches all of the given <see cref="Parameters.labels"/>.
	/// </summary>
	public class ReqAssetListByCompanyAndLabels : ReqAssetListByCompany, IReqListByLabels {
		/// <summary>
		/// The parsed labels given as input.
		/// </summary>
		/// <seealso cref="AssetGeneral.labels"/>
		public string[] labels { get; set; }
	}
	/// <summary>
	/// Gets the list of <see cref="Asset"/>s for the specified <see cref="Company"/> only if one of the specified <see cref="AssetGeneral.references"/> fields match.
	/// If no references are specified, it will match any <see cref="Asset"/> with no references.
	/// If a reference value is null, it will match any <see cref="Asset"/> without that reference key.
	/// </summary>
	public class ReqAssetListByCompanyAndRefPairs : ReqAssetListByCompany, IReqListByReferences {
		/// <summary>
		/// The parsed references given as input.
		/// </summary>
		/// <seealso cref="AssetGeneral.references"/>
		public Dictionary<string, string> references { get; set; }
	}
}