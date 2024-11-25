using System;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container class used to house the "handle" identifying a <see cref="Session"/>.
	/// </summary>
	public class SessionHandle {
		/// <summary>
		/// A "handle" identifying a resource.
		/// </summary>
		public string handle;
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this object belongs
		/// </summary>
		/// <seealso cref="Company.id"/>
		public ulong company;
		/// <summary>
		/// The <see cref="User"/> to which the <see cref="Session"/> belongs.
		/// </summary>
		/// <seealso cref="User.login" />
		public string login;
		/// <summary>
		/// A timestamp for when the <see cref="Session"/> will expire.
		/// </summary>
		public DateTime expiry;
	}
}