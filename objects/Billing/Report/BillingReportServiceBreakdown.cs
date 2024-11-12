using System;

namespace Trakit.Objects {
	/// <summary>
	/// Full breakdown of billable details per targeted asset.
	/// </summary>
	public class BillingReportServiceBreakdown : INamed, IBelongAsset {
		/// <summary>
		/// The asset to which this breakdown instance belongs.
		/// </summary>
		/// <seealso cref="Asset.id" />
		public ulong asset { get; set; }
		/// <summary>
		/// Type of asset.
		/// </summary>
		public AssetType kind { get; set; }
		/// <summary>
		/// Asset's name.
		/// </summary>
		/// <override max-length="100" />
		public string name { get; set; }
		/// <summary>
		/// Notes about the asset.
		/// </summary>
		public string notes { get; set; }
		/// <summary>
		/// Indicates when this Asset was created.
		/// </summary>
		public DateTime created { get; set; }
		/// <summary>
		/// Indicates when this Asset was deleted.
		/// </summary>
		public DateTime? deleted { get; set; }
		/// <summary>
		/// Indicates when this Asset wass suspended from event processing.
		/// </summary>
		public DateTime? suspended { get; set; }
		/// <summary>
		/// Indicates when this Asset was restored after being deleted.
		/// </summary>
		public DateTime? restored { get; set; }
		/// <summary>
		/// Indicates when this Asset was revived after being suspended.
		/// </summary>
		public DateTime? revived { get; set; }
		/// <summary>
		/// Codified label names.
		/// </summary>
		/// <seealso cref="LabelStyle.code" />
		/// <override>
		/// <values format="codified">
		/// <seealso cref="LabelStyle.code" />
		/// </values>
		/// </override>
		public string[] labels { get; set; }
		/// <summary>
		/// The list of devices providing events for this asset.
		/// </summary>
		/// <seealso cref="Provider.id" />
		public string[] providers;
		/// <summary>
		/// The list of phone numbers for this asset.
		/// </summary>
		/// <override>
		/// <values format="phone" />
		/// </override>
		public ulong[] phoneNumbers;
		/// <summary>
		/// Indicates when this Asset was last updated.
		/// </summary>
		public DateTime updatedDts;
		/// <summary>
		/// Number of days this Asset is being billed for.
		/// </summary>
		public double billableDays;
		/// <summary>
		/// Cost per billing cycle for this asset.
		/// </summary>
		public double cost;
		/// <summary>
		/// Number of days this Asset was suspended.
		/// </summary>
		public double suspendedDays;
		/// <summary>
		/// Cost per billing cycle for suspended asset.
		/// </summary>
		public double suspendedCost;
		/// <summary>
		/// Total amount being billed for this asset.
		/// </summary>
		public double total;
	}
}