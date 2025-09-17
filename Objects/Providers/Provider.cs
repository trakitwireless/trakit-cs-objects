using System;
using System.Collections.Generic;
using System.Net;

namespace Trakit.Objects {
	/// <summary>
	/// A device, modem, or service which provides events from the field.
	/// </summary>
	public class Provider : Compound, INamed, IBelongCompany, IDeletable {
		/// <summary>
		/// 
		/// </summary>
		protected override Component[] Pieces => new Component[] {
			this.General,
			this.Advanced,
			this.Control,
		};

		/// <summary>
		/// Unique identifier of this device.
		/// </summary>
		/// <seealso cref="Asset.id" />
		public string id => this.General?.id
						?? this.Advanced?.id
						?? this.Control?.id
						?? throw new NullReferenceException("general");
		/// <summary>
		/// The company to which this device belongs.
		/// </summary>
		/// <seealso cref="Company.id" />
		public ulong company => this.General?.company
							?? this.Advanced?.company
							?? this.Control?.company
							?? throw new NullReferenceException("general");
		/// <summary>
		/// The kind of communication protocol this device uses.
		/// </summary>
		public ProviderType kind => this.General?.kind
							?? throw new NullReferenceException("general");

		/// <summary>
		/// 
		/// </summary>
		public ProviderGeneral General { get; set; }
		/// <summary>
		/// This thing's name.
		/// </summary>
		public string name {
			get => (this.General ?? throw new NullReferenceException("general")).name;
			set => (this.General ?? throw new NullReferenceException("general")).name = value;
		}
		/// <summary>
		/// Notes about it.
		/// </summary>
		public string notes {
			get => (this.General ?? throw new NullReferenceException("general")).notes;
			set => (this.General ?? throw new NullReferenceException("general")).notes = value;
		}
		/// <summary>
		/// The asset for which this device provides field data.
		/// </summary>
		/// <seealso cref="Asset.id" />
		public ulong? asset {
			get => (this.General ?? throw new NullReferenceException("general")).asset;
			set => (this.General ?? throw new NullReferenceException("general")).asset = value;
		}
		/// <summary>
		/// The provider's current (or pending) configuration profile.
		/// </summary>
		/// <seealso cref="ProviderConfig.id" />
		/// <seealso cref="ProviderConfiguration.id" />
		public ulong configuration {
			get => (this.General ?? throw new NullReferenceException("general")).configuration;
			set => (this.General ?? throw new NullReferenceException("general")).configuration = value;
		}
		/// <summary>
		/// The password programmed on the device used to ensure the system is the only client authorized to make changes.
		/// </summary>
		public string password {
			get => (this.General ?? throw new NullReferenceException("general")).password;
			set => (this.General ?? throw new NullReferenceException("general")).password = value;
		}
		/// <summary>
		/// The firmware/application version number.
		/// </summary>
		public string firmware {
			get => (this.General ?? throw new NullReferenceException("general")).firmware;
			set => (this.General ?? throw new NullReferenceException("general")).firmware = value;
		}
		/// <summary>
		/// The phone number of this device.
		/// </summary>
		public ulong? phoneNumber {
			get => (this.General ?? throw new NullReferenceException("general")).phoneNumber;
			set => (this.General ?? throw new NullReferenceException("general")).phoneNumber = value;
		}
		/// <summary>
		/// A list of read-only values about the device like IMEI, ESN, firmware version, hardware revision, etc...
		/// </summary>
		public Dictionary<string, string> information {
			get => (this.General ?? throw new NullReferenceException("general")).information;
			set => (this.General ?? throw new NullReferenceException("general")).information = value;
		}
		/// <summary>
		/// ICCID of the SIM card installed in this provider
		/// </summary>
		public string sim {
			get => (this.General ?? throw new NullReferenceException("general")).sim;
			set => (this.General ?? throw new NullReferenceException("general")).sim = value;
		}

		/// <summary>
		/// 
		/// </summary>
		public ProviderAdvanced Advanced { get; set; }
		/// <summary>
		/// The last IP address of the device.
		/// </summary>
		public IPEndPoint lastIP {
			get => (this.Advanced ?? throw new NullReferenceException("advanced")).lastIP;
			set => (this.Advanced ?? throw new NullReferenceException("advanced")).lastIP = value;
		}
		/// <summary>
		/// Often changing values like latitude, longitude, speed, wiring state, VBus information, etc...
		/// </summary>
		public Dictionary<string, Dictionary<string, ProviderData>> attributes {
			get => (this.Advanced ?? throw new NullReferenceException("advanced")).attributes;
			set => (this.Advanced ?? throw new NullReferenceException("advanced")).attributes = value;
		}
		/// <summary>
		/// Store-and-forward information like last sequence number of SnF window
		/// </summary>
		public Dictionary<string, string> snf {
			get => (this.Advanced ?? throw new NullReferenceException("advanced")).snf;
			set => (this.Advanced ?? throw new NullReferenceException("advanced")).snf = value;
		}

		/// <summary>
		/// 
		/// </summary>
		public ProviderControl Control { get; set; }
		/// <summary>
		/// Collection of commands for this provider.
		/// </summary>
		public Dictionary<ProviderCommandType, ProviderCommand> commands {
			get => (this.Control ?? throw new NullReferenceException("control")).commands;
			set => (this.Control ?? throw new NullReferenceException("control")).commands = value;
		}

		// IRequestable
		/// <summary>
		/// The <see cref="id"/> is the key.
		/// </summary>
		/// <returns></returns>
		public override string GetKey() => this.id;

		// ISuspendable and IDeletable
		/// <summary>
		/// Indicates whether this object was deleted.
		/// </summary>
		public bool? deleted => (this.General ?? throw new NullReferenceException("general")).deleted;
		/// <summary>
		/// Indicates whether this object is suspended from event processing.
		/// </summary>
		public bool? suspended => (this.General ?? throw new NullReferenceException("general")).suspended;
		/// <summary>
		/// Timestamp from the action that deleted or suspended this object.
		/// </summary>
		public DateTime? since => (this.General ?? throw new NullReferenceException("general")).since;
	}
}