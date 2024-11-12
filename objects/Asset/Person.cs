using System;

namespace Trakit.Objects {
	/// <summary>
	/// The full details of a Person, containing all the properties from the <see cref="PersonGeneral"/> and <see cref="AssetAdvanced"/> objects.
	/// </summary>
	public class Person : Asset {
		/// <summary>
		/// General details about this person.
		/// </summary>
		new public PersonGeneral general {
			get => (PersonGeneral)base.general;
			set => base.general = value;
		}

		/// <summary>
		/// A reference to their Company's Contact information.
		/// </summary>
		/// <seealso cref="Contact.id" />
		public ulong contact {
			get => (this.general ?? throw new NullReferenceException("general")).contact;
			set => (this.general ?? throw new NullReferenceException("general")).contact = value;
		}
	}
}