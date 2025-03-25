namespace Trakit.Objects {
	/// <summary>
	/// Rules used for generating a scorecard.
	/// </summary>
	public class ReportScorecardRules {
		/// <summary>
		/// Base score for the scorecard.
		/// </summary>
		public double baseScore;
		/// <summary>
		/// Infraction parameters used to generate the final score
		/// </summary>
		public ReportScorecardParameter[] parameters;
	}
}