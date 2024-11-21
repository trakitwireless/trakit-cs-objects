namespace Trakit.Commands {
	/// <summary>
	/// An object which contains details about the error.
	/// </summary>
	/// <remarks>
	/// Child classes should contain members that best work to describe the details of the error.
	/// This class exists to create an inheritance chain.
	/// </remarks>
	public abstract class ErrorDetail {
		/// <summary>
		/// A hint for deserializing the error's details.
		/// </summary>
		public ErrorDetailType kind;
	}
}