namespace Trakit.Objects {
	/// <summary>
	/// The kind of service being billed.
	/// </summary>
	public enum BillableHostingType : byte {
		/// <summary>
		/// Employee/driver tracking
		/// </summary>
		mobile,
		/// <summary>
		/// Vehicle tracking (includes VBus data, and engine hours)
		/// </summary>
		vehicle,
		/// <summary>
		/// Generic dot-on-a-map tracking
		/// </summary>
		asset,
		/// <summary>
		/// Tasks assignable to vehicles or persons
		/// </summary>
		dispatch,
		/// <summary>
		/// FMCSA compliant E-Logs and Hours of Service
		/// </summary>
		elogs,
		/// <summary>
		/// Inventory management
		/// </summary>
		inventory,
		/// <summary>
		/// Cargo and delivery audit
		/// </summary>
		cargo,
		/// <summary>
		/// Mobile forms
		/// </summary>
		forms,
		/// <summary>
		/// Dashcam and live images hosting
		/// </summary>
		streetview,
	}
}