using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the id and owning <see cref="Company.id"/> of the object requested/created.
	/// </summary>
	public class RespIdCompany : RespId, IBelongCompany {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this object belongs.
		/// </summary>
		public ulong company { get; set; }
	}
}