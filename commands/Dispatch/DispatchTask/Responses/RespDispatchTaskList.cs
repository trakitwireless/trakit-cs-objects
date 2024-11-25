using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="dispatchTasks"/>.
	/// </summary>
	public abstract class RespDispatchTaskList : Response {
		/// <summary>
		/// The list of requested <see cref="DispatchTask"/>s.
		/// </summary>
		public DispatchTask[] dispatchTasks;
	}

	/// <summary>
	/// 
	/// </summary>
	public class RespDispatchTaskListByAsset : RespDispatchTaskList, IRespListByAsset {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public RespId asset { get; set; }
	}
	/// <summary>
	/// 
	/// </summary>
	public class RespDispatchTaskListByAssetAndRefPairs : RespDispatchTaskListByAsset {
		/// <summary>
		/// Case-insensitive reference pairs used to match jobs.
		/// </summary>
		/// <seealso cref="DispatchTask.references"/>
		public Dictionary<string, string> references;
	}

	/// <summary>
	/// 
	/// </summary>
	public class RespDispatchTaskListByCompany : RespDispatchTaskList, IRespListByCompany {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public RespId company { get; set; }
	}
	/// <summary>
	/// 
	/// </summary>
	public class RespDispatchTaskListByCompanyAndRefPairs : RespDispatchTaskListByCompany, IRespListByReferences {
		/// <summary>
		/// Case-insensitive reference pairs used to match jobs.
		/// </summary>
		/// <seealso cref="DispatchTask.references"/>
		public Dictionary<string, string> references { get; set; }
	}
}