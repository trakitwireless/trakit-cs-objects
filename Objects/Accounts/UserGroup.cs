using System;

namespace Trakit.Objects {
	/// <summary>
	/// Members of a group (as set by a <see cref="User"/>'s <see cref="UserAdvanced.groups"/> or <see cref="Machine"/>'s <see cref="Machine.groups"/>)
	/// allow for easy administration of permissions and levels of access.
	/// </summary>
	public class UserGroup : Component, IIdUlong, INamed, IBelongCompany, IDeletable {
		/// <summary>
		/// Unique identifier of this group.
		/// </summary>
		public ulong id { get; set; }
		/// <summary>
		/// The company to which this group belongs.
		/// </summary>
		/// <seealso cref="Company.id" />
		public ulong company { get; set; }
		/// <summary>
		/// A name given to this group.
		/// </summary>
		public string name { get; set; }
		/// <summary>
		/// Notes about this group, and to whom this group should be applied.
		/// </summary>
		public string notes { get; set; }
		/// <summary>
		/// Permissions for this group.
		/// </summary>
		public Permission[] permissions;

		// IRequestable
		/// <summary>
		/// The <see cref="id"/> is the key.
		/// </summary>
		/// <returns></returns>
		public override string GetKey() => this.id.ToString();

		// IDeletable
		/// <summary>
		/// Indicates whether this object was deleted.
		/// </summary>
		public bool? deleted { get; set; }
		/// <summary>
		/// Timestamp from the action that deleted or suspended this object.
		/// </summary>
		public DateTime? since { get; set; }
	}
}