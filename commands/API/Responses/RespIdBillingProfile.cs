namespace Trakit.Commands {
	/// <summary>
	/// A container for the id, <see cref="BillingProfile.id"/>, and owning <see cref="Company.id"/> of the billing object requested/created.
	/// </summary>
	public class RespIdBillingProfile : RespIdCompany {
		/// <summary>
		/// Identifier of the <see cref="BillingProfile"/> to which this object belongs
		/// </summary>
		public ulong profile;
	}
}