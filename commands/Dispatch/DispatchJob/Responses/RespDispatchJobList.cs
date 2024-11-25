using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="dispatchJobs"/>.
	/// </summary>
	public abstract class RespDispatchJobList : Response {
		/// <summary>
		/// The list of requested <see cref="DispatchJob"/>s.
		/// </summary>
		public DispatchJob[] dispatchJobs;
	}

	/// <summary>
	/// 
	/// </summary>
	public class RespDispatchJobListByAsset : RespDispatchJobList, IRespListByAsset {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public RespId asset { get; set; }
	}
	/// <summary>
	/// 
	/// </summary>
	public class RespDispatchJobListByAssetAndRefPairs : RespDispatchJobListByAsset {
		/// <summary>
		/// Case-insensitive reference pairs used to match jobs.
		/// </summary>
		/// <seealso cref="DispatchJob.references"/>
		public Dictionary<string, string> references;
	}

	/// <summary>
	/// 
	/// </summary>
	public class RespDispatchJobListByCompany : RespDispatchJobList, IRespListByCompany {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public RespId company { get; set; }
	}
	/// <summary>
	/// 
	/// </summary>
	public class RespDispatchJobListByCompanyAndLabels : RespDispatchJobListByCompany, IRespListByLabels {
		/// <summary>
		/// A list of <see cref="LabelStyle.code">label codes</see> used to match <see cref="DispatchJob"/>s.
		/// All labels must match to include a <see cref="DispatchJob"/> in the result.
		/// </summary>
		public string[] labels { get; set; }
	}
	/// <summary>
	/// 
	/// </summary>
	public class RespDispatchJobListByCompanyAndRefPairs : RespDispatchJobListByCompany, IRespListByReferences {
		/// <summary>
		/// Case-insensitive reference pairs used to match jobs.
		/// </summary>
		/// <seealso cref="DispatchJob.references"/>
		public Dictionary<string, string> references { get; set; }
	}

	/// <summary>
	/// 
	/// </summary>
	public class RespDispatchJobListByUnassigned : RespDispatchJobListByCompany { }
	/// <summary>
	/// Gets the list of <see cref="DispatchJob"/>s for the specified <see cref="Company"/> which are not assigned to an <see cref="Asset"/>, only if the <see cref="DispatchJob.labels"/> matches all of the given <see cref="labels"/>.
	/// </summary>
	public class RespDispatchJobListByUnassignedAndLabels : RespDispatchJobListByUnassigned, IRespListByLabels {
		/// <summary>
		/// A list of <see cref="LabelStyle.code">label codes</see> used to match <see cref="DispatchJob"/>s.
		/// All labels must match to include a <see cref="DispatchJob"/> in the result.
		/// </summary>
		public string[] labels { get; set; }
	}
	/// <summary>
	/// 
	/// </summary>
	public class RespDispatchJobListByUnassignedAndRefPairs : RespDispatchJobListByUnassigned, IRespListByReferences {
		/// <summary>
		/// Case-insensitive reference pairs used to match jobs.
		/// </summary>
		/// <seealso cref="DispatchJob.references"/>
		public Dictionary<string, string> references { get; set; }
	}
}