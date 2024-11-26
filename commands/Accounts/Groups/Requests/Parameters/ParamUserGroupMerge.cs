using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Parameters used to create or update an <see cref="UserGroup"/>.
	/// </summary>
	public class ParamUserGroupMerge : ParamMergeSubscribable {
		/// <summary>
		/// The unique identifier of the <see cref="UserGroup"/> you want to update.
		/// </summary>
		public ulong? id;
		/// <summary>
		/// The company to which this <see cref="UserGroup"/> belongs.
		/// After creation, this value is read-only.
		/// </summary>
		public ulong? company;
		/// <summary>
		/// Name for the <see cref="UserGroup"/>.
		/// </summary>
		public string name;
		/// <summary>
		/// Notes for the <see cref="UserGroup"/>.
		/// </summary>
		public string notes;
		/// <summary>
		/// List of permissions assigned to members of this <see cref="UserGroup"/>.
		/// </summary>
		public List<ParamPermission> permissions;
	}
}