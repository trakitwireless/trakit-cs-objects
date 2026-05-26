namespace Trakit.Objects {
	/// <summary>
	/// Types of multi-factor authentication implementations for a <see cref="Company"/>.
	/// </summary>
	public enum MultiFactorType : byte {
		/// <summary>
		/// Use a mobile authenticator app from Apple, Google, Microsoft, or others.
		/// </summary>
		app,
		/// <summary>
		/// Receive an SMS message with a PIN code to continue logging-in.
		/// </summary>
		sms,
		/// <summary>
		/// Receive an email with a PIN code to continue logging-in.
		/// </summary>
		email,
	}
}