namespace Trakit.Commands {
	/// <summary>
	/// These details contain a list of bad keys, labels or tags, unique identifiers, or parameter names that caused the failure.
	/// </summary>
	public abstract class ErrorDetailBadBase<T> : ErrorDetail {
		/// <summary>
		/// List of bad ids or keys or whatever.
		/// </summary>
		public T[] invalid;
	}
}