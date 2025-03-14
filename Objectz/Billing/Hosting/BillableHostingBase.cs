using System;

namespace Trakit.Objects {
	/// <summary>
	/// Hosted things share a lot of common attributes.
	/// </summary>
	public abstract class BillableHostingBase : Component, IIdUlong, IBelongBillingProfile, IBelongCompany, IDeletable {
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