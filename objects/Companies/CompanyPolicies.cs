namespace Trakit.Objects {
	/// <summary>
	/// The password and session lifetime policies for this Company.
	/// </summary>
	public class CompanyPolicies : Component, IIdUlong, IAmCompany {
		/// <summary>
		/// Unique identifier of the Company.
		/// </summary>
		/// <seealso cref="Company.id" />
		public ulong id { get; set; }
		/// <summary>
		/// The unique identifier of this company's parent organization.
		/// </summary>
		/// <seealso cref="Company.id" />
		public ulong parent { get; set; }
		/// <summary>
		/// The session lifetime policy.
		/// </summary>
		public SessionPolicy sessionPolicy;
		/// <summary>
		/// The password complexity and expiry policy.
		/// </summary>
		public PasswordPolicy passwordPolicy;

		// IRequestable
		/// <summary>
		/// The <see cref="id"/> is the key.
		/// </summary>
		/// <returns></returns>
		public override string GetKey() => this.id.ToString();
	}
}