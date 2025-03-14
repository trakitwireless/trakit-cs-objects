using System.Collections.Generic;

namespace Trakit.Objects {
	/// <summary>
	/// Scorecard generated from the results of this report.
	/// </summary>
	public class ReportScorecard {
		/// <summary>
		/// The asset to which this scorecard belongs.
		/// </summary>
		/// <seealso cref="Asset.id" />
		public ulong asset;
		/// <summary>
		/// Final score calculated based on scorecard rules.
		/// </summary>
		public double score;
		/// <summary>
		/// Points per rule
		/// </summary>
		public Dictionary<string, double> rulePoints;
	}
}