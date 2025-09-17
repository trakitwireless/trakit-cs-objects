namespace Trakit.Objects {
	/// <summary>
	/// The options used by the report runner to process results.
	/// </summary>
	public class ReportOptions {
		/// <summary>
		/// A list of parameters to better shape the results.
		/// </summary>
		public ReportParameter[] parameters;
		/// <summary>
		/// A targeting expression for including/excluding Assets.
		/// </summary>
		public string targets;
		/// <summary>
		/// The mechanism to use for filtering based on places and regions.
		/// </summary>
		public ReportFilterMode filtering;
		/// <summary>
		/// A targeting expression for limiting results which only include data from Assets interacting with the targeted Places.
		/// </summary>
		public string places;
		/// <summary>
		/// A list of provinces and states, where only assets within those regions will be included in the results.
		/// </summary>
		public string[] regions;
		/// <summary>
		/// Rules used to generate scorecard for this report.
		/// </summary>
		public ReportScorecardRules scorecardRules;
	}
}