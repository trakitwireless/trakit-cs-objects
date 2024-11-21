namespace Trakit.Commands {
	/// <summary>
	/// For unhandled exceptions, a full stack trace may be given.
	/// </summary>
	/// <remarks>
	/// Only available for some of the beta services.
	/// </remarks>
	public class ErrorDetailStack : ErrorDetail {
		/// <summary>
		/// Exception message.
		/// </summary>
		public string message;
		/// <summary>
		/// The full stack trace if available.
		/// </summary>
		public string stack;
	}
}