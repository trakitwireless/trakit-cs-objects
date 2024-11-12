namespace Trakit.Commands {
	/// <summary>
	/// For batch commands, these are the errors thrown by the sub-command.
	/// </summary>
	public class ErrorDetailBatch : ErrorDetail {
		/// <summary>
		/// Index-presevered list of sub-command errors.
		/// </summary>
		public Response[] errors;
	}
}