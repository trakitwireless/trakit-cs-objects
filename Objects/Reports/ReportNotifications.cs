namespace Trakit.Objects {
	/// <summary>
	/// A group of users and targeted assets which receive report notifications.
	/// </summary>
	public class ReportNotifications {
		/// <summary>
		/// List of users to send emailed report.
		/// Each email will only contain the results for the assets each user is allowed to view.
		/// </summary>
		public string[] users;
		/// <summary>
		/// A targeting expression to identify which assets receive the report results.
		/// The results emailed to each asset will only be for themselves, not all assets.
		/// To receive the emailed results, the Asset must have a <see cref="AssetGeneral.messagingAddress"/>,
		/// or for a Person type asset, their <see cref="Contact.emails"/>["Email"].
		/// </summary>
		public string assets;
	}
}