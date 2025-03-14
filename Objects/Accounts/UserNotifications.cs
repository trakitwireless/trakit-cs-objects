using System;

namespace Trakit.Objects {
	/// <summary>
	/// Definition of how and when to send alerts to the user.
	/// </summary>
	public class UserNotifications : IEnabled {
		/// <summary>
		/// A common name like "Weekdays" or "Off Hours".
		/// </summary>
		/// <override max-length="100" />
		public string name;
		/// <summary>
		/// A flag for whether or not this schedule is in use.
		/// </summary>
		public bool enabled { get; set; }
		/// <summary>
		/// A 7 item, boolean array, determines if the user should be notified on that day of the week.
		/// The days of the week are defined in local time, not UTC.
		/// </summary>
		/// <seealso cref="UserGeneral.timezone" />
		/// <override count="7" />
		public bool[] weekdays;
		/// <summary>
		/// Start time portion of the schedule that defines a period of the day when the user wants to receive alerts.
		/// The time value is defined in local time, not UTC.
		/// </summary>
		/// <seealso cref="UserGeneral.timezone" />
		public TimeSpan start;
		/// <summary>
		/// End time portion of the schedule that defines a period of the day when the user wants to receive alerts.
		/// The time value is defined in local time, not UTC.
		/// </summary>
		/// <seealso cref="UserGeneral.timezone" />
		public TimeSpan end;
		/// <summary>
		/// Email address where the sent is sent.
		/// If not specified, the email address from the User's <see cref="Contact"/> is taken.
		/// If the contact has no email address, the alert is sent to the user's login.
		/// </summary>
		/// <override min-length="6" max-length="254" format="email" />
		public string email;
		/// <summary>
		/// SMS address where the alert is sent.
		/// If not specified, the mobile phone number from the User's <see cref="Contact"/> is taken.
		/// If the contact has no mobile phone number, the alert is not sent.
		/// </summary>
		public ulong? sms;
		/// <summary>
		/// A list of the types of methods to use to notify the user when they have an active WebSocket connection.
		/// </summary>
		public UserNotificationsMethod[] online;
		/// <summary>
		/// A list of the types of methods to use to notify the user when they are not connected.
		/// </summary>
		public UserNotificationsMethod[] offline;
	}
}