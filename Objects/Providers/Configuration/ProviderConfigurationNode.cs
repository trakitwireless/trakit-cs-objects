using System;
using System.Collections.Generic;

namespace Trakit.Objects {
	/// <summary>
	/// This tree-like structure is given to the script processor for the device type so that the device can follow a program.
	/// </summary>
	[Obsolete("Use ProviderScriptBlock instead")]
	public class ProviderConfigurationNode {
		/// <summary>
		/// Indicates that this configuration is an advanced property and should only be set by someone who knows what they're doing.
		/// </summary>
		public bool isAdvanced = true;
		/// <summary>
		/// Unique identifier of the value being mapped.
		/// </summary>
		public string id = string.Empty;
		/// <summary>
		/// The value being set.
		/// </summary>
		public object value;
		/// <summary>
		/// The minimum possible value for this confugration node.
		/// </summary>
		public object min;
		/// <summary>
		/// The maximum possible value for this confugration node.
		/// </summary>
		public object max;
		/// <summary>
		/// Type hint used by the script processor to help format the value.
		/// </summary>
		public string type;
		/// <summary>
		/// Unit hint used to help the script processor format the value.
		/// </summary>
		public string unit;
		/// <summary>
		/// Description of what this configuration does when mapped to a device.
		/// </summary>
		public string notes;
		/// <summary>
		/// Child configuration nodes.
		/// </summary>
		public Dictionary<string, ProviderConfigurationNode> nodes;
	}
}