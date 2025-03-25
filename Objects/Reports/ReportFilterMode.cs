namespace Trakit.Objects {
	/// <summary>
	/// Drill-down mechanism for highlighting only those places and regions desired in report results.
	/// </summary>
	public enum ReportFilterMode : byte {
		/// <summary>
		/// Filtering is not enabled for the report.
		/// </summary>
		none,
		/// <summary>
		/// Include any results for those whose filters match.
		/// </summary>
		inclusive,
		/// <summary>
		/// Exclude all results except those whose filters match.
		/// </summary>
		exclusive,
	}
}