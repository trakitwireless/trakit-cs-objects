namespace Trakit.Commands {
	/// <summary>
	/// Details for how many and which <see cref="FormResult"/>s are still using this <see cref="FormTemplate"/>.
	/// </summary>
	public class ErrorDetailFormTemplateInUse : ErrorDetail {
		/// <summary>
		/// A list of <see cref="FormResult.id"/>s currently being referenced.
		/// </summary>
		public ulong[] formResults;
	}
}