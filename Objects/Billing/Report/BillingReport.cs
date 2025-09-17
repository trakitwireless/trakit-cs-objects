using System;

namespace Trakit.Objects {
	/// <summary>
	/// Report generated per billee company.
	/// </summary>
	public class BillingReport : Component, IIdUlong, INamed, IBelongCompany, IBelongBillingProfile, IDeletable {
		/// <summary>
		/// Unique identifier
		/// </summary>
		public ulong id { get; set; }
		/// <summary>
		/// The company to which this report belongs and is sending the bill.
		/// </summary>
		/// <seealso cref="Company.id" />
		public ulong company { get; set; }
		/// <summary>
		/// Unique identifier of the Company receiving the bill.
		/// </summary>
		/// <seealso cref="Company.id" />
		public ulong billee { get; set; }
		/// <summary>
		/// The profile to which this report belongs
		/// </summary>
		/// <seealso cref="BillingProfile.id" />
		public ulong profile { get; set; }
		/// <summary>
		/// Name of this report.
		/// </summary>
		public string name { get; set; }
		/// <summary>
		/// Notes about this report.
		/// </summary>
		public string notes { get; set; }
		/// <summary>
		/// First day of the billing cycle
		/// </summary>
		public DateTime startDate;
		/// <summary>
		/// Last day of the billing cycle
		/// </summary>
		public DateTime endDate;
		/// <summary>
		/// Total amount being billed.
		/// </summary>
		public double total;
		/// <summary>
		/// Currency being billed in
		/// </summary>
		public BillingCurrency currency { get; set; }
		/// <summary>
		/// The processing status of this report.
		/// </summary>
		public BillingReportStatus status;
		/// <summary>
		/// A field which contains report error details if the <see cref="status"/> is <see cref="BillingReportStatus.failed"/>.
		/// </summary>
		/// <seealso cref="BillingReportStatus" />
		public string error;
		/// <summary>
		/// Summary contains totals per target for this billee
		/// </summary>
		public BillingReportSummary[] summary;
		/// <summary>
		/// Individual amounts per company, used to calculate the results of the report.
		/// </summary>
		public BillingReportBreakdown[] breakdown;

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