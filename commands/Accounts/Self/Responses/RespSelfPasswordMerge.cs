using System;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class RespSelfPasswordMerge : Response {
		/// <summary>
		/// Specific date/time of when the password will expire.
		/// </summary>
		public DateTime? expires;
		/// <summary>
		/// Your <see cref="Company"/>'s <see cref="PasswordPolicy">password policy</see>.
		/// </summary>
		public PasswordPolicy passwordPolicy;
	}
}