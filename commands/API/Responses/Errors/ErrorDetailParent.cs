namespace Trakit.Commands {
	/// <summary>
	/// Details for how a circular company tree would have been created.
	/// </summary>
	public class ErrorDetailParent : ErrorDetail {
		/// <summary>
		/// The <see cref="Company.parent"/> specified in the parameters.
		/// </summary>
		public ulong parent;
		/// <summary>
		/// ID of the child <see cref="Company"/> that would cause a circular reference.
		/// </summary>
		public ulong descendant;
	}
}