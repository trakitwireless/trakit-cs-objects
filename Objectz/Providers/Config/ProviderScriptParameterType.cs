namespace Trakit.Objects {
	/// <summary>
	/// Possible data-types given to ProviderScriptParameter.
	/// </summary>
	public enum ProviderScriptParameterType : byte {
		/// <summary>
		/// True or false.
		/// </summary>
		boolean,
		/// <summary>
		/// Numeric value (double-precision floating point number).
		/// </summary>
		number,
		/// <summary>
		/// Text.
		/// </summary>
		text,
	}
}