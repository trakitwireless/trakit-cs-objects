using System;

namespace Trakit.Objects {
	/// <summary>
	/// Most billable things share common attibutes.
	/// </summary>
	public abstract class BillableBase : Component, IIdUlong, INamed, IBelongBillingProfile, IBelongCompany, IDeletable {
		/// <summary>
		/// Unique identifier of this hosting rule.
		/// </summary>
		public ulong id { get; set; }
		/// <summary>
		/// Unique identifier of the Company that owns this hosting rule.
		/// </summary>
		/// <seealso cref="Company.id" />
		public ulong company { get; set; }
		/// <summary>
		/// Unique identifier of this rule's billing profile.
		/// </summary>
		/// <seealso cref="BillingProfile.id" />
		public ulong profile { get; set; }
		/// <summary>
		/// The name of this billing rule.
		/// </summary>
		/// <override max-length="254" />
		public string name { get; set; }
		/// <summary>
		/// Notes about billing this rule.
		/// </summary>
		public string notes { get; set; }
		/// <summary>
		/// A custom field used to refer to an external system.  Examples are a cost codes, SOCs, discount plans...
		/// </summary>
		/// <override max-length="100" />
		public string reference;
		/// <summary>
		/// SKU or SOC code
		/// </summary>
		/// <override max-length="20" />
		public string sku;
		/// <summary>
		/// Date this billing rule takes effect.
		/// These dates are used to determine how much of the cycle is billed.
		/// </summary>
		public DateTime start;
		/// <summary>
		/// Date this billing rule is applied until; null means it never ends.
		/// These dates are used to determine how much of the cycle is billed.
		/// </summary>
		public DateTime? end;
		/// <summary>
		/// Cost per cycle for this plan
		/// </summary>
		public double amount;

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