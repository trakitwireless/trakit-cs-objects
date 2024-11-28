namespace Trakit.Objects {
	/// <summary>
	/// Possible data-types given to BehaviourParameters.
	/// </summary>
	public enum BehaviourParameterType : byte {
		/// <summary>
		/// True or false.
		/// </summary>
		boolean,
		/// <summary>
		/// Numeric value (signed double-precision floating point number).
		/// </summary>
		number,
		/// <summary>
		/// Text.
		/// </summary>
		text,
		/// <summary>
		/// Object or array literal.
		/// </summary>
		json,
	}
}