using System;

namespace Trakit.Objects {
	/// <summary>
	/// Full breakdown of licensing details per targeted provider.
	/// </summary>
	public class BillingReportLicenseBreakdown : INamed {
		/// <summary>
		/// The provider to which this breakdown instance belongs.
		/// </summary>
		/// <seealso cref="Provider.id" />
		public string provider { get; set; }
		/// <summary>
		/// Type of provider.
		/// </summary>
		public ProviderType kind { get; set; }
		/// <summary>
		/// Provider name.
		/// </summary>
		/// <override max-length="100" />
		public string name { get; set; }
		/// <summary>
		/// Notes about the provider.
		/// </summary>
		public string notes { get; set; }
		/// <summary>
		/// Indicates when this Provider was created.
		/// </summary>
		public DateTime created { get; set; }
		/// <summary>
		/// Indicates when this Provider was deleted.
		/// </summary>
		public DateTime? deleted { get; set; }
		/// <summary>
		/// The phone number for this provider.
		/// </summary>
		public ulong? phoneNumber;
		/// <summary>
		/// The firmware/application version number.
		/// </summary>
		/// <override max-length="100" />
		public string firmware;
		/// <summary>
		/// Number of days this Provider is being billed for.
		/// </summary>
		public double billableDays;
		/// <summary>
		/// Licensing cost per billing cycle for this provider.
		/// </summary>
		public double cost;
		/// <summary>
		/// Total amount being billed for this provider.
		/// </summary>
		public double total;
	}
}