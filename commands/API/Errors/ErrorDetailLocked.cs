using System;

namespace Trakit.Commands {
	/// <summary>
	/// Details for how long a resource is locked, or if a command cannot be executed right away, how long until it can be executed.
	/// </summary>
	public class ErrorDetailLocked : ErrorDetail {
		/// <summary>
		/// The amount of time the resource is locked, or you are prevented from issuing the command.
		/// </summary>
		public TimeSpan? timeout;
		/// <summary>
		/// This timestamp represents the moment the resource becomes available again.
		/// </summary>
		public DateTime? until;
	}
}