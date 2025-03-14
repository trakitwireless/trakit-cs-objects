namespace Trakit.Objects {
	/// <summary>
	/// Permissions and group membership defined for a user.
	/// </summary>
	public class UserAdvanced : Component, IBelongCompany, IHavePermissions {
		/// <summary>
		/// The unique public email address used to access the system.
		/// </summary>
		/// <seealso cref="User.login" />
		/// <override min-length="6" max-length="254" format="email" />
		public string login { get; set; }
		/// <summary>
		/// The company to which this user belongs.
		/// </summary>
		/// <seealso cref="Company.id" />
		public ulong company { get; set; }
		/// <summary>
		/// A list of groups to which this user belongs.
		/// </summary>
		/// <seealso cref="UserGroup.id" />
		public ulong[] groups { get; set; }
		/// <summary>
		/// Individual permission rules which override the group rules.
		/// </summary>
		public Permission[] permissions { get; set; }

		// IRequestable
		/// <summary>
		/// The <see cref="login"/> is the key.
		/// </summary>
		/// <returns></returns>
		public override string GetKey() => this.login;
	}
}