namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="providerRegistration"/>.
	/// </summary>
	public class RespProviderRegistrationMerge : Response {
		/// <summary>
		/// An object which contains the <c>id</c> and <c>company</c> keys when there is no error.
		/// </summary>
		public RespIdCompany providerRegistration;
	}
}