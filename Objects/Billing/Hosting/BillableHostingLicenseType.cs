namespace Trakit.Objects {
	/// <summary>
	/// The kind of license being billed.
	/// </summary>
	public enum BillableHostingLicenseType : byte {
		/// <summary>
		/// SmartWitness data hosting fee
		/// </summary>
		/// <seealso cref="ProviderType.smartwitness" />
		smartwitness,
		/// <summary>
		/// BeWhere license fee
		/// </summary>
		/// <seealso cref="ProviderType.bewhere" />
		bewhere,
		/// <summary>
		/// CalAmp PULS fee
		/// </summary>
		/// <seealso cref="ProviderType.calamp" />
		calamp,
	}
}