using System;

namespace Trakit.Objects {
	/// <summary>
	/// Infraction parameter used to generate scorecard
	/// </summary>
	public class ReportScorecardParameter {
		/// <summary>
		/// Type of exception, example speeding, idling, etc.
		/// </summary>
		public string condition;
		/// <summary>
		/// Threshold per instance. If the threshold is 0, each instance is used in the calculation
		/// </summary>
		public TimeSpan duration;
		/// <summary>
		/// Points applied against the base score per instance
		/// </summary>
		public double points;
	}
}