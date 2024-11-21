using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets a list of <see cref="AssetAdvanced"/>s.
	/// </summary>
	public abstract class ReqAssetAdvancedList : Request, IReqIDeletable, IReqISuspendable {
		/// <summary>
		/// When true, the command will also return <see cref="AssetAdvancedMessage"/>s for the asset.
		/// </summary>
		public bool includeMessages { get; set; }
		/// <summary>
		/// When true, the command will also return <see cref="DispatchTask"/>s for the asset.
		/// </summary>
		public bool includeTasks { get; set; }
		/// <summary>
		/// When true, the command will also return suspended <see cref="AssetAdvanced"/>s.
		/// </summary>
		public bool includeSuspended { get; set; }
		/// <summary>
		/// When true, the command will also return a deleted <see cref="AssetAdvanced"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}

	/// <summary>
	/// Gets the list of <see cref="AssetAdvanced"/>s for the specified <see cref="Company"/>.
	/// </summary>
	public class ReqAssetAdvancedListByCompany : ReqAssetAdvancedList, IReqListByCompany {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ParamId company { get; set; }
	}
	/// <summary>
	/// Gets the list of <see cref="AssetAdvanced"/>s for the specified <see cref="Company"/> only if the <see cref="AssetAdvancedGeneral.labels"/> matches all of the given <see cref="Parameters.labels"/>.
	/// </summary>
	public class ReqAssetAdvancedListByCompanyAndLabels : ReqAssetAdvancedListByCompany, IReqListByLabels {
		/// <summary>
		/// The parsed labels given as input.
		/// </summary>
		/// <seealso cref="AssetAdvancedGeneral.labels"/>
		public string[] labels { get; set; }
	}
	/// <summary>
	/// Gets the list of <see cref="AssetAdvanced"/>s for the specified <see cref="Company"/> only if one of the specified <see cref="AssetAdvancedGeneral.references"/> fields match.
	/// If no references are specified, it will match any <see cref="AssetAdvanced"/> with no references.
	/// If a reference value is null, it will match any <see cref="AssetAdvanced"/> without that reference key.
	/// </summary>
	public class ReqAssetAdvancedListByCompanyAndRefPairs : ReqAssetAdvancedListByCompany, IReqListByReferences {
		/// <summary>
		/// The parsed references given as input.
		/// </summary>
		/// <seealso cref="AssetAdvancedGeneral.references"/>
		public Dictionary<string, string> references { get; set; }
	}
}