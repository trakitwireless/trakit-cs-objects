namespace Trakit.Commands {
	/// <summary>
	/// These are the details when a number of things create the exception.
	/// </summary>
	public class ErrorDetailCount : ErrorDetail {
		/// <summary>
		/// The number of items that failed, or number of items preventing success.
		/// </summary>
		public int count;
	}
}