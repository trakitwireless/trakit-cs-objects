namespace Trakit.Objects {
	/// <summary>
	/// A conversational message between users and assets.
	/// </summary>
	public class AssetMessage : MessageBase {
		/// <summary>
		/// The folder under which this message is stored.
		/// </summary>
		public MessageFolder folder;
		/// <summary>
		/// Indicates that this is a received message instead of a sent message.
		/// </summary>
		public bool incoming;
		/// <summary>
		/// The user that read this message.  This field is blank/null when unread.
		/// </summary>
		/// <seealso cref="User.login" />
		public string readBy;
	}
}