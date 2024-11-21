namespace Trakit.Commands {
	/// <summary>
	/// An abstract meant to help with validating "merge" operations.
	/// </summary>
	public abstract class ParamMergeSubscribable : ParamMerge {
		/// <summary>
		/// The version keys used to validate synchronization.
		/// </summary>
		public int[] v;
	}
}