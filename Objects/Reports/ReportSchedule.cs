using System;

namespace Trakit.Objects {
	/// <summary>
	/// Determines when and how often a report schedule runs automatically.
	/// </summary>
	public class ReportSchedule : Component, IIdUlong, INamed, IEnabled, IBelongCompany, IDeletable {
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
		/// A reference to the Template used to create this result.
		/// </summary>
		/// <seealso cref="ReportTemplate.id" />
		public ulong template;
		/// <summary>
		/// Login of the user who has ownership of this report schedule.
		/// </summary>
		/// <seealso cref="User.login" />
		public string owner;
		/// <summary>
		/// Name of this report.
		/// </summary>
		public string name { get; set; }
		/// <summary>
		/// Notes about this report.
		/// </summary>
		public string notes { get; set; }
		/// <summary>
		/// Indicates whether this schedule is allowed to run.
		/// </summary>
		public bool enabled { get; set; }
		/// <summary>
		/// The recurring schedule to generate report results.
		/// </summary>
		public ReportRecurrence repetition;
		/// <summary>
		/// Specified parameters for the report logic, targeted Assets, and filtering Places.
		/// </summary>
		public ReportOptions options;
		/// <summary>
		/// A list of users and a targeting expression for assets which receive report results notifications.
		/// </summary>
		public ReportNotifications notify;

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