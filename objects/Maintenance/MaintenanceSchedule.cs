using System;
using System.Collections.Generic;

namespace Trakit.Objects {
	/// <summary>
	/// Recurring service work
	/// </summary>
	public class MaintenanceSchedule : Component, IIdUlong, INamed, IBelongCompany, IVisual, IDeletable {
		/// <summary>
		/// Unique identifier
		/// </summary>
		public ulong id { get; set; }
		/// <summary>
		/// The company to which this schedule belongs
		/// </summary>
		/// <seealso cref="Company.id" />
		public ulong company { get; set; }
		/// <summary>
		/// The name of the work to be done.  Like "oil change".
		/// </summary>
		/// <override max-length="100" />
		public string name { get; set; }
		/// <summary>
		/// Notes about the work to be done.  Like "change the oil and oil filter".
		/// </summary>
		public string notes { get; set; }
		/// <summary>
		/// The targeting expression to select which Vehicles and Trailers require this maintenance work.
		/// </summary>
		public string targets;
		/// <summary>
		/// List of Users to send notifications.
		/// </summary>
		/// <override>
		/// <values format="email">
		/// <seealso cref="User.login" />
		/// </values>
		/// </override>
		public string[] notify;

		/// <summary>
		/// The fill/background colour of the icon.
		/// </summary>
		/// <override max-length="22" format="colour" />
		public string fill { get; set; }
		/// <summary>
		/// Outline and graphic colour.
		/// </summary>
		/// <override max-length="22" format="colour" />
		public string stroke { get; set; }
		/// <summary>
		/// The name of the symbol for this schedule.
		/// </summary>
		/// <override max-length="22" format="codified" />
		public string graphic { get; set; }

		/// <summary>
		/// The number of days in advance to predict a job will become pending.
		/// </summary>
		/// <override min-value="5" max-value="180" />
		public uint predictionDays;
		/// <summary>
		/// The number of days between service visits.
		/// </summary>
		public uint? recurDays;
		/// <summary>
		/// The amount of mileage between service visits.
		/// </summary>
		public double? recurDistance;
		/// <summary>
		/// The number of operating hours between service visits.
		/// </summary>
		public double? recurEngineHours;
		/// <summary>
		/// The per-asset details calculated by the system to help predict the creation of Maintenance Jobs.
		/// </summary>
		/// <override>
		/// <keys>
		/// <seealso cref="Asset.id" />
		/// </keys>
		/// </override>
		public Dictionary<ulong, MaintenanceRecurrence> intervals;

		// ------------ repair details ------------
		/// <summary>
		/// The name of the garage or service facility where the work is done.
		/// </summary>
		/// <override max-length="100" />
		public string garage;
		/// <summary>
		/// The estimated time for the job.
		/// </summary>
		public TimeSpan duration;
		/// <summary>
		/// The estimated cost for the job cost in dollars.
		/// </summary>
		public double cost;
		/// <summary>
		/// A reference code used to track this job
		/// </summary>
		/// <override max-length="100" />
		public string reference;

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