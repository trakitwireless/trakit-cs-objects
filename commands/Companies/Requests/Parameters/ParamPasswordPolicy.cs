using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Parameter values for creating a new or updating an existing <see cref="PasswordPolicy"/>.
	/// </summary>
	public class ParamPasswordPolicy : ParamMerge {
		/// <summary>
		/// The minimum number of characters required.
		/// </summary>
		public byte? minimumLength;
		/// <summary>
		/// Do passwords require alphabetical characters.
		/// </summary>
		public bool? includeLetters;
		/// <summary>
		/// Do passwords require numeric characters.
		/// </summary>
		public bool? includeNumbers;
		/// <summary>
		/// Do passwords require upper-case and lower-case letters.
		/// </summary>
		public bool? includeUpperLower;
		/// <summary>
		/// Do passwords require non-alphanumeric characters.
		/// </summary>
		public bool? includeSpecial;
		/// <summary>
		/// Defines how passwords expire.
		/// </summary>
		public PasswordExpiryMode? expireMode;
		/// <summary>
		/// The threshold for expiry (in days).
		/// </summary>
		public byte? expireThreshold;  
	}
}