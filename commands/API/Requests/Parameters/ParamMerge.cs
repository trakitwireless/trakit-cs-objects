namespace Trakit.Commands {
	/// <summary>
	/// An abstract meant to help with validating "merge" operations.
	/// </summary>
	public abstract class ParamMerge {
		/// <summary>
		/// A list of keys given to this object so we can differentiate between null and undefined.
		/// </summary>
		public string[] givenKeys;
	}
}