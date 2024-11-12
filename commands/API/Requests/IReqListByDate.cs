using System;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public interface IReqListByDate {
		/// <summary>
		/// 
		/// </summary>
		DateTime? after { get; set; }
		/// <summary>
		/// 
		/// </summary>
		DateTime? before { get; set; }
	}
}