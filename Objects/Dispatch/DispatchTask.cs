using System;
using System.Collections.Generic;

namespace Trakit.Objects {
	/// <summary>
	/// A task assigned to an asset which represents a coordinate on the map which must be visited.
	/// </summary>
	[Obsolete("Use DispatchJob instead")]
	public class DispatchTask : Component, IIdUlong, IBelongCompany, IBelongAsset, IDeletable {
		/// <summary>
		/// Unique identifier of this task.
		/// </summary>
		public ulong id { get; set; }
		/// <summary>
		/// The company to which this task belongs.
		/// </summary>
		/// <seealso cref="Company.id" />
		public ulong company { get; set; }
		/// <summary>
		/// The asset to which this task belongs.
		/// </summary>
		/// <seealso cref="Asset.id" />
		public ulong asset { get; set; }
		/// <summary>
		/// The name of this task or the work needed to be performed.
		/// </summary>
		public string name;
		/// <summary>
		/// Name/value collections of custom fields used to refer to external systems.
		/// </summary>
		public Dictionary<string, string> references;
		/// <summary>
		/// An optional place which can be used as a template instead of providing lat/long coordinates and a street address.
		/// </summary>
		/// <seealso cref="Place.id" />
		public ulong? place;
		/// <summary>
		/// The street address of where the task must be completed.
		/// </summary>
		public string address;
		/// <summary>
		/// The lat/long coordinates of where the task must be completed.
		/// </summary>
		public LatLng latlng;
		/// <summary>
		/// The progress of this task.
		/// </summary>
		public DispatchTaskStatus status;
		/// <summary>
		/// When this task was created.
		/// </summary>
		public DateTime created;
		/// <summary>
		/// The optional estimated time of arrival for the asset.
		/// </summary>
		public DateTime? eta;
		/// <summary>
		/// The optional expected duration of the work for this task.
		/// </summary>
		public TimeSpan? duration;
		/// <summary>
		/// The date/time stamp of when the asset arrived at this task.
		/// </summary>
		public DateTime? arrived;
		/// <summary>
		/// The date/time stamp of when this task was completed.
		/// </summary>
		public DateTime? completed;
		/// <summary>
		/// Instructions (filled out by dispatcher) for the field-employee to help them completed the task.
		/// </summary>
		public string instructions;
		/// <summary>
		/// Indicates whether the task has a signature.
		/// </summary>
		public bool signature;
		/// <summary>
		/// The name of the person who signed the task's completion.
		/// </summary>
		public string signatory;
		/// <summary>
		/// Notes about the status of the work filled in by field-employee.
		/// </summary>
		public string notes;
		/// <summary>
		/// A list of hosted <see cref="Document"/> identifiers attached to this task.
		/// </summary>
		public ulong[] attachments;
		/// <summary>
		/// Either the user's login, or provider's identifier that changed this task
		/// </summary>
		public string updatedBy;
		/// <summary>
		/// Timestamp from the last change made to this task
		/// </summary>
		public DateTime updatedUtc;

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