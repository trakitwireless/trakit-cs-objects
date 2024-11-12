namespace Trakit.Objects {
	/// <summary>
	/// Summarized bill per target.
	/// </summary>
	public class BillingReportSummary : INamed {
		/// <summary>
		/// The target company to which this summary instance belongs.
		/// </summary>
		/// <seealso cref="Company.id" />
		public ulong target{ get; set; }
		/// <summary>
		/// The target company's parent.
		/// </summary>
		/// <seealso cref="Company.id" />
		public ulong parent{ get; set; }
		/// <summary>
		/// Target's name.
		/// </summary>
		/// <override max-length="100" />
		public string name { get; set; }
		/// <summary>
		/// Notes about the target.
		/// </summary>
		public string notes { get; set; }
		/// <summary>
		/// Summary contains totals per type of hosting (services and licenses) for this target
		/// </summary>
		public BillingReportHostingSummary[] hosting;
	}
}