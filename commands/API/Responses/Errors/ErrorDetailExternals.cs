namespace Trakit.Commands {
	/// <summary>
	/// These are the errors/warnings taken from the output of some other system.
	/// </summary>
	public class ErrorDetailExternals : ErrorDetail {
		/// <summary>
		/// List of errors.
		/// </summary>
		public string[] errors;
		/// <summary>
		/// List of warnings.
		/// </summary>
		public string[] warnings;
		/// <summary>
		/// List of messages.
		/// </summary>
		public string[] messages;
	}
}