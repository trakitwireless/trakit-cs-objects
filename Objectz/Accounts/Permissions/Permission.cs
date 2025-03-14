using System;

namespace Trakit.Objects {
	/// <summary>
	/// A defined permission for <see cref="User"/>s, <see cref="UserGroup"/>s, and <see cref="Machine"/>s.
	/// </summary>
	public class Permission {
		/// <summary>
		/// The <see cref="Company"/> that this permission targets.
		/// </summary>
		/// <seealso cref="Company.id" />
		public ulong company;
		/// <summary>
		/// The type of permission.
		/// </summary>
		public PermissionType kind;
		/// <summary>
		/// The kind of permission.
		/// </summary>
		/// <override type="Vorgon.UserPermissionType"/>
		[Obsolete("Use .kind instead")]
		public string type {
			get => this.kind.ToString();
			set => this.kind = (PermissionType)Enum.Parse(typeof(PermissionType), value, true);
		}
		/// <summary>
		/// The level of access being defined.
		/// </summary>
		public PermissionLevel level;
		/// <summary>
		/// The way the access is used.
		/// </summary>
		public PermissionMethod method;
		/// <summary>
		/// Codified names of <see cref="LabelStyle"/>s.  If list is empty, this permission applies for all labels.
		/// </summary>
		/// <override>
		/// <values format="codified">
		/// <seealso cref="LabelStyle.code" />
		/// </values>
		/// </override>
		public string[] labels;
	}
}