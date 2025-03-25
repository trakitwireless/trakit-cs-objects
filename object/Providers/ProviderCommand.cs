using System;

namespace Trakit.Objects {
	/// <summary>
	/// Details regarding a provider command
	/// </summary>
	public class ProviderCommand {
		/// <summary>
		/// Current status of this command.
		/// </summary>
		public ProviderCommandStatus status;
		/// <summary>
		/// Command message body.
		/// </summary>
		public string[] parameters;
		/// <summary>
		/// Date/time stamp of when the command was created.
		/// </summary>
		public DateTime created;
		/// <summary>
		/// Date/time stamp of when the command was processed.
		/// </summary>
		public DateTime? processed;
	}
}