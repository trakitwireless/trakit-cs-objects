using Newtonsoft.Json;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Allows a <see cref="User"/> to change their own password.
	/// </summary>
	public class ReqSelfPassword : Request {
		/// <summary>
		/// Your current password, as verification that you are the proper account owner.
		/// </summary>
		[JsonIgnore]
		public string current;
		/// <summary>
		/// Your new password must conform to your company's <see cref="PasswordPolicy">password policy</see>.
		/// </summary>
		[JsonIgnore]
		public string password;
	}
}