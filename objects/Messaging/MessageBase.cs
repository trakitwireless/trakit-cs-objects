using System;

namespace Trakit.Objects {
	/// <summary>
	/// A base class for Alerts and Messages.
	/// </summary>
	public abstract class MessageBase : Component, IIdUlong, IBelongCompany, IBelongAsset, IDeletable {
		/// <summary>
		/// Unique identifier of this memo.
		/// </summary>
		public ulong id { get; set; }
		/// <summary>
		/// The company to which this memo belongs.
		/// </summary>
		/// <seealso cref="Company.id" />
		public ulong company { get; set; }
		/// <summary>
		/// Lifetime status
		/// </summary>
		public MessageStatus status;
		/// <summary>
		/// Protocol type
		/// </summary>
		public MessageType kind { get; set; }
		/// <summary>
		/// Recipient address
		/// </summary>
		/// <override min-length="6" max-length="254" />
		public string to;
		/// <summary>
		/// Sender address
		/// </summary>
		/// <override min-length="6" max-length="254" />
		public string from;
		/// <summary>
		/// The main contents of the memo.
		/// </summary>
		public string body;
		/// <summary>
		/// Date/time stamp of when the memo was processed.
		/// </summary>
		public DateTime? processed;
		/// <summary>
		/// Date/time stamp of when the memo was delivered (or sent if delivery information unavailable).
		/// </summary>
		public DateTime? delivered;

		/// <summary>
		/// The subject of this message.
		/// </summary>
		/// <override max-length="100" />
		public string subject;
		/// <summary>
		/// The asset to which this message relates.
		/// </summary>
		/// <seealso cref="Asset.id" />
		public ulong asset { get; set; }
		/// <summary>
		/// The user who sent/received this message.
		/// </summary>
		/// <seealso cref="User.login" />
		/// <override max-length="254" format="email" />
		public string user { get; set; }

		// IRequestable
		/// <summary>
		/// The <see cref="id"/> is the key.
		/// </summary>
		/// <returns></returns>
		public override string getKey() => this.id.ToString();

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