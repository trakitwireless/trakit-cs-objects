namespace Trakit.Commands {
	/// <summary>
	/// These are the details of a phone number input that failed to parse.
	/// </summary>
	public class ErrorDetailPhone : ErrorDetailInput {
		/// <summary>
		/// The number that was parsed from the input.
		/// </summary>
		public ulong number;
		/// <summary>
		/// The digital characters used to try to parse the number.
		/// </summary>
		public string usable;
	}
}