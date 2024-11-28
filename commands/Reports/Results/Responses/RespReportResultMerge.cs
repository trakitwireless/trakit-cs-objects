namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="reportResult"/>.
	/// </summary>
	public class RespReportResultMerge : Response {
		/// <summary>
		/// An object which contains the <c>id</c> and <c>company</c> keys when there is no error.
		/// </summary>
		public RespIdCompany reportResult;
	}
}