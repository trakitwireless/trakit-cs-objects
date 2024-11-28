using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="ProviderRegistration"/>.
	/// </summary>
	public class ReqProviderRegistrationGet : ReqProviderRegistration, IReqIDeletable {
		/// <summary>
		/// When true, the command will also return a deleted <see cref="ProviderRegistration"/> (if it exists).
		/// </summary>
		public bool includeDeleted { get; set; }
	}
}