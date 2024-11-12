using System;
using System.Collections.Generic;

namespace Trakit.Objects {
	/// <summary>
	/// This read-only class describes a type of logic applied to a provider.
	/// ProviderConfigurationTypes are used to help define a ProviderConfiguration.
	/// </summary>
	[Obsolete("Use ProviderScript instead")]
	public class ProviderConfigurationType : Component, IIdUlong, INamed, IDeletable {
		/// <summary>
		/// Unique identifier.
		/// </summary>
		public ulong id { get; set; }
		/// <summary>
		/// Name of the configuration type.
		/// </summary>
		/// <override max-length="100" />
		public string name { get; set; }
		/// <summary>
		/// Notes regarding the use of this configuration.
		/// </summary>
		public string notes { get; set; }
		/// <summary>
		/// The applicable type of provider for which this configuration type can be created.
		/// </summary>
		public ProviderType providerType;
		/// <summary>
		/// The maximum number of geofences that can be programmed onto a device. This number changes based on device make and model, and can also change based on the supported geofence types.
		/// </summary>
		/// <override type="System.UInt32" />
		public int maxGeofenceCount;
		/// <summary>
		/// The minimum number of geofences that need to be programmed onto the device. This value is almost always zero.
		/// </summary>
		/// <override type="System.UInt32" />
		public int minGeofenceCount;
		/// <summary>
		/// A tree-structure of configurations required (or optionally available) for programming a device.
		/// </summary>
		public Dictionary<string, ProviderConfigurationNode> scriptOptions;
		/// <summary>
		/// A list of supported types of geofences which can be programmed directly onto the device.
		/// </summary>
		public PlaceType[] geofenceTypes;

		// IRequestable
		/// <summary>
		/// The <see cref="id"/> is the key.
		/// </summary>
		/// <returns></returns>
		public override string GetKey() => this.id.ToString();

		// IDeletable
		/// <summary>
		/// Indicates whether this object was deleted.
		/// </summary>
		public bool? deleted { get; set; }
		/// <summary>
		/// Timestamp from the action that deleted or suspended this object.
		/// </summary>
		public DateTime? since { get; set; }
	}
}