namespace Trakit.Objects {
	/// <summary>
	/// Amount billed for a type of hosting (service or license) per target company.
	/// </summary>
	public class BillingReportHostingSummary {
		/// <summary>
		/// SKU being billed
		/// </summary>
		public string sku { get; set; }
		/// <summary>
		/// Cost per billing cycle for this SKU.
		/// </summary>
		public double cost;
		/// <summary>
		/// Number of items for this SKU.
		/// </summary>
		public double count;
		/// <summary>
		/// Total amount being billed for this SKU.
		/// </summary>
		public double total;
	}
}