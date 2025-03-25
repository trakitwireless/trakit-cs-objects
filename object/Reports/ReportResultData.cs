using System.Collections.Generic;

namespace Trakit.Objects {
	/// <summary>
	/// Report results which also include the computed summary and breakdown for the results.
	/// </summary>
	public class ReportResultData : ReportResult {
		/// <summary>
		/// Grouped events form a summary instance, and contain information about the starting, ending, and number of the grouped events.
		/// </summary>
		public Dictionary<ulong, ReportSummary[]> summary;
		/// <summary>
		/// Individual events about the targeted assets used to calculate the results of the report.
		/// </summary>
		public Dictionary<ulong, ReportBreakdown[]> breakdown;
	}
}