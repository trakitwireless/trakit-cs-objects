namespace Trakit.Objects {
	/// <summary>
	/// Seldom changing details about a person.
	/// </summary>
	public class PersonGeneral : AssetGeneral {
		/// <summary>
		/// A reference to their Company's Contact information.
		/// </summary>
		/// <seealso cref="Contact.id" />
		public ulong contact;
	}
}