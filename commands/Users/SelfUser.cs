using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Similar to the <see cref="User"/> object, but instead of the <see cref="SelfUserGeneral.contact"/>
	/// and <see cref="groups"/> properties being identifiers of other objects,
	/// the <see cref="Contact"/> and <see cref="UserGroup"/> objects are embedded within.
	/// </summary>
	public class SelfUser : SelfUserGeneral {
		/// <summary>
		/// Individual permission rules which override the <see cref="UserGroup"/> rules.
		/// </summary>
		public Permission[] permissions;
		/// <summary>
		/// The list of <see cref="UserGroup"/>s to which this <see cref="User"/> belongs.
		/// </summary>
		public UserGroup[] groups;
	}
}