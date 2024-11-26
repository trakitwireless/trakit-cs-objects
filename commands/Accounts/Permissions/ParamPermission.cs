using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Similar to the <see cref="Permission"/> object, but the <see cref="company"/>, <see cref="level"/>, <see cref="method"/>, and <see cref="labels"/> are all optional.
	/// </summary>
	/// <category>Users and Groups</category>
	public class ParamPermission {
		/// <summary>
		/// The <see cref="Company"/> that this permission targets.
		/// If not given, will default to the <see cref="UserAdvanced.company"/>, <see cref="UserGroup.company"/> or <see cref="Machine.company"/> to which it belongs.
		/// </summary>
		/// <seealso cref="Company.id" />
		public ulong? company;
		/// <summary>
		/// The kind of <see cref="PermissionType"/>.
		/// </summary>
		/// <override required="always" />
		public PermissionType kind;
		/// <summary>
		/// The level of access being defined.
		/// </summary>
		/// <override value="read"/>
		public PermissionLevel? level;
		/// <summary>
		/// The way the access is used.
		/// </summary>
		/// <override value="grant"/>
		public PermissionMethod? method;
		/// <summary>
		/// Codified names of <see cref="CompanyLabels.labels"/>.  If list is empty, this permission applies for all labels.
		/// </summary>
		/// <override>
		/// <values format="codified">
		/// <seealso cref="LabelStyle.code" />
		/// </values>
		/// </override>
		public string[] labels;
	}
}