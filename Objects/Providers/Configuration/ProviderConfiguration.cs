using System;
using System.Collections.Generic;

namespace Trakit.Objects {
	/// <summary>
	/// The configured logic loaded onto the provider over-the-air to control it's reporting schedule and behaviour.
	/// </summary>
	[Obsolete("Use ProviderConfig instead")]
	public class ProviderConfiguration : Component, IIdUlong, INamed, IBelongCompany, IDeletable {
		/// <summary>
		/// Unique identifier of this configuration.
		/// </summary>
		public ulong id { get; set; }
		/// <summary>
		/// The company to which this configuration belongs.
		/// </summary>
		/// <seealso cref="Company.id" />
		public ulong company { get; set; }
		/// <summary>
		/// The nickname given to this configuration
		/// </summary>
		public string name { get; set; }
		/// <summary>
		/// Simple details about how the providers are expected to behave.
		/// </summary>
		public string notes { get; set; }
		/// <summary>
		/// The logic type which this configuration implements.
		/// </summary>
		/// <seealso cref="ProviderConfigurationType.id" />
		public ulong type { get; set; }
		/// <summary>
		/// The list of defined variables given to the <see cref="ProviderConfigurationType.scriptOptions">logic type's options</see> pairs for the logic type requires.
		/// </summary>
		public Dictionary<string, object> scriptParameters;
		/// <summary>
		/// List of Places loaded directly onto the provider.
		/// </summary>
		public ulong[] geofences;

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