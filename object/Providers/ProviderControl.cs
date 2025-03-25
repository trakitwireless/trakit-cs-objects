using System.Collections.Generic;

namespace Trakit.Objects {
	/// <summary>
	/// Managing communication with Device/hardware.
	/// </summary>
	public class ProviderControl : Component, IBelongCompany {
		/// <summary>
		/// Unique identifier of this device.
		/// </summary>
		/// <seealso cref="Provider.id" />
		/// <override min-length="10" max-length="50" />
		public string id { get; set; }
		/// <summary>
		/// The company to which this device belongs.
		/// </summary>
		/// <seealso cref="Company.id" />
		public ulong company { get; set; }
		/// <summary>
		/// Collection of commands for this provider.
		/// </summary>
		public Dictionary<ProviderCommandType, ProviderCommand> commands;

		// IRequestable
		/// <summary>
		/// The <see cref="id"/> is the key.
		/// </summary>
		/// <returns></returns>
		public override string GetKey() => this.id;
	}
}