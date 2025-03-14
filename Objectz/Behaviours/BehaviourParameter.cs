namespace Trakit.Objects {
	/// <summary>
	/// Definition of an argument passed to a Behaviour Script.
	/// </summary>
	public class BehaviourParameter {
		/// <summary>
		/// Simple type information for the compiler.
		/// </summary>
		public BehaviourParameterType kind;
		/// <summary>
		/// The value is given as a string, but parsed into native type when compiled.
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
	}
}