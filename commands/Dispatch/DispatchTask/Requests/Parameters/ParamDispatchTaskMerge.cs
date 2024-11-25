using System;
using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Parameters used to create a new, or update an existing <see cref="DispatchTask"/>.
	/// </summary>
	public class ParamDispatchTaskMerge : ParamMergeSubscribable {
		/// <summary>
		/// The unique identifier of the <see cref="DispatchTask"/> you want to update.
		/// </summary>
		public ulong? id;
		/// <summary>
		/// The identifier of the <see cref="Asset"/> assigned to this <see cref="DispatchTask"/>.
		/// </summary>
		public ulong? asset;
		/// <summary>
		/// Name for the <see cref="DispatchTask"/>.
		/// </summary>
		public string name;
		/// <summary>
		/// Notes completed by the driver about the <see cref="DispatchTask"/>.
		/// Such as service notes, damaged goods upon pick-up, etc...
		/// </summary>
		public string notes;
		/// <summary>
		/// A custom field used to refer this <see cref="DispatchTask"/> an external system. Examples are a work order, pick-up, waybill, etc...
		/// If value is null, the field is removed from the <see cref="DispatchTask"/>.
		/// If a new value or null is not provided for a current attribute, no change is made.
		/// </summary>
		public Dictionary<string, string> references;
		/// <summary>
		/// The street address of this <see cref="DispatchTask"/>.
		/// Condition: You must provide a <c>place</c>, a <c>latlng</c>, or an <c>address</c>.
		/// Note: If you ommit the <c>address</c>, the geocoder attempts to populate the field, but will not return an error if it fails.
		/// </summary>
		public string address;
		/// <summary>
		/// An optional identifier of a <see cref="Place"/> for this <see cref="DispatchTask"/>.  Using a <see cref="Place"/> makes detecting the "arrived" status more reliable.
		/// Condition: You must provide a <c>place</c>, a <c>latlng</c>, or an <c>address</c>.
		/// Note: If you invoke the geocoder, the <c>address</c> is also replaced with the geocoded value.
		/// </summary>
		public ulong? place;
		/// <summary>
		/// Instructions for the driver to help them complete the <see cref="DispatchTask"/>.
		/// Such as which door to use, a buzz code to enter the facility, etc...
		/// </summary>
		public string instructions;
		/// <summary>
		/// A list of <see cref="Document"/> identifiers to attach to this <see cref="DispatchTask"/> for both driver and dispatcher review.
		/// </summary>
		public List<ulong> attachments;
		/// <summary>
		/// The lat/long coordinates of the street address.
		/// Condition: You must provide a <c>place</c>, a <c>latlng</c>, or an <c>address</c>.
		/// Note: If you invoke the geocoder, the <c>address</c> is also replaced with the geocoded value.
		/// </summary>
		public LatLng latlng;
		/// <summary>
		/// Estimated time of arrival.
		/// </summary>
		public DateTime? eta;
		/// <summary>
		/// The duration on site, or how much time is expected to complete the <see cref="DispatchTask"/>.  Used to help calculate other <see cref="DispatchTask"/> ETAs when routing is performed.
		/// </summary>
		public TimeSpan? duration;
		/// <summary>
		/// <see cref="DispatchTask"/>s have a lifetime and each status represents a <see cref="DispatchTask"/>'s progress through it's life.
		/// </summary>
		public DispatchTaskStatus? status;
	}
}