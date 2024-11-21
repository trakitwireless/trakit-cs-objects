namespace Trakit.Commands {
	/// <summary>
	/// These are the details of an enum input that failed to parse.
	/// </summary>
	public class ErrorDetailEnum : ErrorDetailInput {
		/// <summary>
		/// This is a list of possible values the input should have been.
		/// </summary>
		public string[] valid;
	}
}