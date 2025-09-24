using System;
using Newtonsoft.Json;

namespace Trakit.Objects {
	/// <summary>
	/// The temporary reference to a device whose ownership is pending.
	/// </summary>
	public class ProviderRegistration : IRequestable, INamed, IBelongCompany, IDeletable {
		/// <summary>
		/// A unique six digit code.
		/// </summary>
		public string code;
		/// <summary>
		/// The company to which the device will belong.
		/// </summary>
		/// <seealso cref="Company.id" />
		public ulong company { get; set; }
		/// <summary>
		/// A nickname given to the device once it has been provisioned.
		/// </summary>
		public string name { get; set; }
		/// <summary>
		/// Notes!
		/// </summary>
		public string notes { get; set; }
		/// <summary>
		/// The password programmed on the device used to ensure the system is the only client authorized to make changes.
		/// </summary>
		public string password;
		/// <summary>
		/// The unique identifier the user who generated this registration.
		/// </summary>
		/// <seealso cref="User.login" />
		public string user;
		/// <summary>
		/// The predefined configuration this device will use.
		/// </summary>
		/// <seealso cref="ProviderConfig.id" />
		/// <seealso cref="ProviderConfiguration.id" />
		public ulong config;
		/// <summary>
		/// The kind of protocol this device supports.
		/// </summary>
		public ProviderType kind;
		/// <summary>
		/// Date/time stamp of when this registration began.
		/// </summary>
		public DateTime since;
		/// <summary>
		/// Date/time stamp of when this registration ended successfully.
		/// </summary>
		public DateTime? completed;
		/// <summary>
		/// The expiry date for this registration.
		/// </summary>
		public DateTime expires;
		/// <summary>
		/// The unique identifier of the device that completed this registration.
		/// </summary>
		/// <seealso cref="Provider.id" />
		[JsonProperty(NullValueHandling = NullValueHandling.Include)]
		public string identifier;
		/// <summary>
		/// The Asset for which this device will provide data.
		/// </summary>
		/// <seealso cref="Asset.id" />
		[JsonProperty(NullValueHandling = NullValueHandling.Include)]
		public ulong? asset;
		/// <summary>
		/// The phone number of the device being provisioned.
		/// This is set by the user for long-term registrations, or by the client during serial port setup.
		/// </summary>
		public ulong? phoneNumber;

		// IRequestable
		/// <summary>
		/// The <see cref="id"/> is the key.
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.code;

		// IDeletable
		/// <summary>
		/// Indicates whether this object was deleted.
		/// </summary>
		public bool? deleted => this.expires < DateTime.UtcNow;
		/// <summary>
		/// Timestamp from the action that deleted or suspended this object.
		/// </summary>
		DateTime? IDeletable.since => this.since;
	}
}