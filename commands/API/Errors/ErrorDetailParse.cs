namespace Trakit.Commands {
	/// <summary>
	/// These are the details of an exception while trying to parse the JSON input.
	/// </summary>
	public class ErrorDetailParse : ErrorDetail {
		/// <summary>
		/// The line number in the input string.
		/// </summary>
		public int line;
		/// <summary>
		/// The character on which the failure occurred.
		/// </summary>
		public int column;
		/// <summary>
		/// The last sucessfully parsed object.
		/// </summary>
		public string after;
	}
}