using System;

namespace Trakit.Objects {
	/// <summary>
	/// A profile used to generate billable orders for a customer.
	/// </summary>
	public class BillingProfile : Component, IIdUlong, INamed, IBelongCompany, IDeletable {
		/// <summary>
		/// Unique identifier of this billing profile
		/// </summary>
		public ulong id { get; set; }
		/// <summary>
		/// Unique identifier of the Company that owns this profile and is sending the bill.
		/// </summary>
		/// <seealso cref="Company.id" />
		public ulong company { get; set; }
		/// <summary>
		/// Unique identifier of the Company to which this rule pertains.
		/// </summary>
		/// <seealso cref="Company.id" />
		public ulong target { get; set; }
		/// <summary>
		/// Unique identifier of the Company receiving the bill.
		/// Most of the time, this value is the same as the target.
		/// </summary>
		/// <seealso cref="Company.id" />
		public ulong billee { get; set; }
		/// <summary>
		/// The name for this profile
		/// </summary>
		/// <override max-length="254" />
		public string name { get; set; }
		/// <summary>
		/// Notes about the billing profile for the billee or target.
		/// </summary>
		/// <override max-length="1000" />
		public string notes { get; set; }
		/// <summary>
		/// SMS messaging tiers
		/// </summary>
		public BillableSmsProfile[] messages;
		/// <summary>
		/// Repeating cycle used for generating bills
		/// </summary>
		public BillingCycle cycle;
		/// <summary>
		/// When is the first day of the billing cycle
		/// </summary>
		public DateTime cycleStart;
		/// <summary>
		/// When should the cycle end (customer cancelled)
		/// </summary>
		public DateTime? cycleEnd;
		/// <summary>
		/// Pro-rated, or post-dated.
		/// </summary>
		public bool cyclePostDated;
		/// <summary>
		/// kind of money
		/// </summary>
		public BillingCurrency currency;
		/// <summary>
		/// Are the Google services available to be proxied by the service?
		/// </summary>
		public bool googleServicesEnabled;

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