using System;

namespace Trakit.Objects {
	/// <summary>
	/// Report results
	/// </summary>
	public class ReportResult : Component, IIdUlong, INamed, IBelongCompany, IDeletable {
		/// <summary>
		/// Unique identifier
		/// </summary>
		public ulong id { get; set; }
		/// <summary>
		/// The company to which this report belongs
		/// </summary>
		/// <seealso cref="Company.id" />
		public ulong company { get; set; }
		/// <summary>
		/// Refers to the type of logic used by this report.
		/// </summary>
		public ReportType kind { get; set; }
		/// <summary>
		/// Name of this report.
		/// </summary>
		public string name { get; set; }
		/// <summary>
		/// Notes about this report.
		/// </summary>
		public string notes { get; set; }
		/// <summary>
		/// Specified parameters for the report logic, targeted Assets, and filtering Places.
		/// </summary>
		public ReportOptions options;
		/// <summary>
		/// A reference to the Template used to create this result.  This field is optional because templates are not necessarily required; they just make life a lot easier.
		/// </summary>
		/// <seealso cref="ReportTemplate.id" />
		public ulong? template;
		/// <summary>
		/// A reference to the schedule used to create this result.
		/// This field is optional as not all results are created on a schedule.
		/// </summary>
		/// <seealso cref="ReportSchedule.id" />
		public ulong? schedule;
		/// <summary>
		/// Preserve these results for later review.  Results are regularly culled from the system.
		/// </summary>
		public bool archive;
		/// <summary>
		/// The timezone code used to adjust dates/times used in processing and saving this report.
		/// </summary>
		/// <seealso cref="Timezone.code" />
		public Timezone timezone;
		/// <summary>
		/// The login of the user that ran this report.
		/// </summary>
		/// <seealso cref="User.login" />
		public string runBy;
		/// <summary>
		/// The date/time this result was requested.
		/// </summary>
		public DateTime created;
		/// <summary>
		/// The date/time this result was finished processing.
		/// </summary>
		public DateTime? completed;
		/// <summary>
		/// The processing status of this report.
		/// </summary>
		public ReportStatus status;
		/// <summary>
		/// The progress in processing/saving this result is a number between 0 and 100.
		/// </summary>
		public byte progress;
		/// <summary>
		/// After processing, the boundary of the results are given so that a map can be focused on that area.
		/// </summary>
		public LatLngBounds bounds;
		/// <summary>
		/// When the report runs, a list of targeted assets is calculated based on the ReportOption's targeting expression.
		/// </summary>
		public ulong[] targeted;
		/// <summary>
		/// When the report runs, a list of filtered places is calculated based on the ReportOption's place filtering expression.
		/// </summary>
		public ulong[] filtered;
		/// <summary>
		/// After processing, the report totals the values from all summary instances for a quick overview of the kind of results generated.
		/// </summary>
		public ReportDataTotal[] totals;
		/// <summary>
		/// Scorecards for all the targeted assets based on the scorecard rules.
		/// </summary>
		public ReportScorecard[] scorecards;
		/// <summary>
		/// A field which contains report error details if the <see cref="status"/> is <see cref="ReportStatus.failed"/>.
		/// </summary>
		/// <seealso cref="ReportStatus" />
		public string error;

		// IRequestable
		/// <summary>
		/// The <see cref="id"/> is the key.
		/// </summary>
		/// <returns></returns>
		public override string GetKey() => this.id.ToString();

		// IDeletable
		/// <summary>
		/// Indicates whether this object was deleted.
		/// </summary>
		public bool? deleted { get; set; }
		/// <summary>
		/// Timestamp from the action that deleted or suspended this object.
		/// </summary>
		public DateTime? since { get; set; }
	}
}