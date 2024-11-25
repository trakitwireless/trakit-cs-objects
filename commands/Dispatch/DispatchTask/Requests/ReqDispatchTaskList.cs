using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public abstract class ReqDispatchTaskList : Request, IReqIDeletable {
		/// <summary>
		/// When true, the command will also return  deleted <see cref="DispatchTask"/>s.
		/// </summary>
		public bool includeDeleted { get; set; }
	}

	/// <summary>
	/// Gets the list of <see cref="DispatchTask"/>s for the specified <see cref="Asset"/>.
	/// </summary>
	public class ReqDispatchTaskListByAsset : ReqDispatchTaskList, IReqListByAsset {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ParamId asset { get; set; }
	}
	/// <summary>
	/// Gets the list of <see cref="DispatchTask"/>s for the specified <see cref="Asset"/> only if the specified reference fields match.
	/// If no references are specified, it will match any <see cref="DispatchTask"/> with no references.
	/// If a reference value is null, it will match any <see cref="DispatchTask"/> without that reference key.
	/// </summary>
	public class ReqDispatchTaskListByAssetAndRefPairs : ReqDispatchTaskListByAsset {
		/// <summary>
		/// Case-insensitive reference pairs used to match jobs.
		/// </summary>
		/// <seealso cref="DispatchTask.references"/>
		public Dictionary<string, string> references;
	}

	/// <summary>
	/// Gets the list of <see cref="DispatchTask"/>s for the specified <see cref="Company"/>.
	/// </summary>
	public class ReqDispatchTaskListByCompany : ReqDispatchTaskList, IReqListByCompany {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public ParamId company { get; set; }
	}
	/// <summary>
	/// Gets the list of <see cref="DispatchTask"/>s for the specified <see cref="Company"/> only if the specified reference fields match.
	/// If no references are specified, it will match any <see cref="DispatchTask"/> with no references.
	/// If a reference value is null, it will match any <see cref="DispatchTask"/> without that reference key.
	/// </summary>
	public class ReqDispatchTaskListByCompanyAndRefPairs : ReqDispatchTaskListByCompany, IReqListByReferences {
		/// <summary>
		/// Case-insensitive reference pairs used to match jobs.
		/// </summary>
		/// <seealso cref="DispatchTask.references"/>
		public Dictionary<string, string> references { get; set; }
	}
}