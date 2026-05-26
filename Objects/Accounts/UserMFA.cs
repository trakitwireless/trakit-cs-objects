using System;

namespace Trakit.Objects {
	/// <summary>
	/// Multi-factor authentication details for a user.
	/// </summary>
	public class UserMFA  {
		/// <summary>
		/// Indicates whether MFA is enabled for the user.
		/// </summary>
		public bool enabled { get; set; }
		/// <summary>
		/// The type of MFA configured for the user.
		/// </summary>
		public MultiFactorType kind { get; set; }
		/// <summary>
		///	Phone number or email address associated with the MFA method.
		/// </summary>
		public string address { get; set; }
		/// <summary>
		/// Indicates if MFA setup has been completed and verified.
		/// </summary>
		public bool verified { get; set; }
		/// <summary>
		/// The date when MFA was set up.
		/// </summary>
		public readonly DateTime? setupDate;
		/// <summary>
		/// The last time the user authenticated using MFA.
		/// </summary>
		public DateTime? lastAuthentication { get; set; }
	}
}