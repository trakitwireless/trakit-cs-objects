using System;

namespace Trakit.Objects {
	/// <summary>
	/// Summarized asset details.
	/// </summary>
	public class ReportSummary {
		/// <summary>
		/// The asset to which this summary instance belongs.
		/// </summary>
		/// <seealso cref="Asset.id" />
		public ulong asset;
		/// <summary>
		/// Code given to this summary instance for an asset.
		/// </summary>
		public string stateDetail;
		/// <summary>
		/// Identifier of the summary instance in the report.
		/// </summary>
		public uint instance;
		/// <summary>
		/// The number of events included in calculating this summary instance.
		/// </summary>
		public uint instancesCount;
		/// <summary>
		/// Date/time stamp of the first event in this summary's sequence.
		/// </summary>
		public DateTime startingUtc;
		/// <summary>
		/// The reason code that this summary instance began.
		/// </summary>
		public ReportSummaryReason startingReason;
		/// <summary>
		/// Date/time stamp of the last event in this summary's sequence.
		/// </summary>
		public DateTime endingUtc;
		/// <summary>
		/// The reason code that this summary instance ended.
		/// </summary>
		public ReportSummaryReason endingReason = ReportSummaryReason.outsideRange;
		/// <summary>
		/// The distance travelled in kilometres by the asset during this summary instance.
		/// </summary>
		public double distance{ get; set; }
		/// <summary>
		/// The amount of time that passed.
		/// </summary>
		public TimeSpan duration => this.endingUtc - this.startingUtc;
		/// <summary>
		/// A simplified polyline of all the asset's positions in sequence.
		/// </summary>
		public LatLng[] polyline;
		/// <summary>
		/// The first asset state which begins this summary instance.
		/// </summary>
		public Asset firstState;
		/// <summary>
		/// The asset state that ended this summary instance.
		/// </summary>
		public Asset lastState;
	}
}