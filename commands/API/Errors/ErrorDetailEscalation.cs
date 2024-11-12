using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Details of a permission escallation error thrown when modifying a resource or user that would grant the following extra permissions.
	/// </summary>
	public class ErrorDetailEscalation : ErrorDetail {
		/// <summary>
		/// A list of escallated permission details.
		/// </summary>
		public PermissionEscalation[] escalations;
	}
}