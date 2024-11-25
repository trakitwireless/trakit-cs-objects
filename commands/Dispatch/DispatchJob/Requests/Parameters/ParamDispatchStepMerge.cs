using System;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Parameter values for updating the <see cref="DispatchStep"/> for a <see cref="DispatchJob"/>.
	/// </summary>
	public class ParamDispatchStepMerge : ParamMergeSubscribable {
		/// <summary>
		/// The identifier of the step.
		/// Identifiers are unique to a <see cref="DispatchJob"/>, but are not unique system-wide.
		/// </summary>
		public ulong? id;
		/// <summary>
		/// A name for the work needed to be performed.
		/// </summary>
		public string name;
		/// <summary>
		/// The optional estimated time of arrival for the asset.
		/// </summary>
		public DateTime? eta;
		/// <summary>
		/// The optional expected duration of the work for this step.
		/// </summary>
		public TimeSpan? duration;
		/// <summary>
		/// An optional place which can be used as a template instead of providing lat/long coordinates and a street address.
		/// </summary>
		/// <seealso cref="Place.id" />
		public ulong? place;
		/// <summary>
		/// The street address of where the step must be completed.
		/// </summary>
		public string address;
		/// <summary>
		/// The lat/long coordinates of where the step must be <see cref="DispatchStepStatus.completed"/>.
		/// </summary>
		public LatLng latlng;
		/// <summary>
		/// When true, will mean a signature is required to complete this <see cref="DispatchStep"/>.
		/// </summary>
		public bool? signature;
	}
}