using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets a list of <see cref="AssetDispatch"/>s.
	/// </summary>
	public abstract class ReqAssetDispatchList : Request, IReqIDeletable, IReqISuspendable {
		/// <summary>
		/// When true, the command will also return <see cref="AssetDispatchMessage"/>s for the asset.
		/// </summary>
		public bool includeMessages { get; set; }
		/// <summary>
		/// When true, the command will also return <see cref="DispatchTask"/>s for the asset.
		/// </summary>
		public bool includeTasks { get; set; }
		/// <summary>
		/// When true, the command will also return suspended <see cref="AssetDispatch"/>s.
		/// </summary>
		public bool includeSuspended { get; set; }
		/// <summary>
		/// When true, the command will also return a deleted <see cref="AssetDispatch"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}

	/// <summary>
	/// Gets the list of <see cref="AssetDispatch"/>s for the specified <see cref="Company"/>.
	/// </summary>
	public class ReqAssetDispatchListByCompany : ReqAssetDispatchList, IReqListByCompany {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ParamId company { get; set; }
	}
	/// <summary>
	/// Gets the list of <see cref="AssetDispatch"/>s for the specified <see cref="Company"/> only if the <see cref="AssetDispatchGeneral.labels"/> matches all of the given <see cref="Parameters.labels"/>.
	/// </summary>
	public class ReqAssetDispatchListByCompanyAndLabels : ReqAssetDispatchListByCompany, IReqListByLabels {
		/// <summary>
		/// The parsed labels given as input.
		/// </summary>
		/// <seealso cref="AssetDispatchGeneral.labels"/>
		public string[] labels { get; set; }
	}
	/// <summary>
	/// Gets the list of <see cref="AssetDispatch"/>s for the specified <see cref="Company"/> only if one of the specified <see cref="AssetDispatchGeneral.references"/> fields match.
	/// If no references are specified, it will match any <see cref="AssetDispatch"/> with no references.
	/// If a reference value is null, it will match any <see cref="AssetDispatch"/> without that reference key.
	/// </summary>
	public class ReqAssetDispatchListByCompanyAndRefPairs : ReqAssetDispatchListByCompany, IReqListByReferences {
		/// <summary>
		/// The parsed references given as input.
		/// </summary>
		/// <seealso cref="AssetDispatchGeneral.references"/>
		public Dictionary<string, string> references { get; set; }
	}
}