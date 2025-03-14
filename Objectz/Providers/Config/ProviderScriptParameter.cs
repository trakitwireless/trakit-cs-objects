namespace Trakit.Objects {
	/// <summary>
	/// Definition of an argument passed to a ProviderScript.
	/// </summary>
	public class ProviderScriptParameter {
		/// <summary>
		/// Simple type information for the gateway to process.
		/// </summary>
		public ProviderScriptParameterType kind;
		/// <summary>
		/// The value is given as a string, but parsed into native type when used by the gateway.
		/// </summary>
		public string value;
		/// <summary>
		/// Usage notes.
		/// </summary>
		public string notes;
		/// <summary>
		/// Gives a hint to the client on the best UI to use for editing.
		/// For example, "checkbox" is a good UI hint for boolean parameter types.
		/// </summary>
		public string context;
		/// <summary>
		/// The order in which this parameter is displayed compared to other parameters.
		/// The value has no effect on how this parameter is inserted into the ProviderScriptBlocks.
		/// </summary>
		public uint order;
		/// <summary>
		/// Used as a hint that this parameter controls an advanced script option and should only be set if you really know what you're doing.
		/// </summary>
		public bool advanced;
	}
}