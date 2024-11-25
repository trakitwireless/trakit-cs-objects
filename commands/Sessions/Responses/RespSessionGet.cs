using System;
using Newtonsoft.Json;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="User"/> or <see cref="Machine"/> of the current session.
	/// </summary>
	public class RespSessionGet : Response {
		/// <summary>
		/// The requested <see cref="SessionDetails"/>.
		/// </summary>
		public SessionDetails session;
	}
}