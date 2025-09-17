using System;

namespace Trakit.Objects {
	/// <summary>
	/// Driving directions and details like duration and distance.
	/// </summary>
	public class DispatchDirection {
		/// <summary>
		/// The total distance of these directions (including sub-directions if applicable).
		/// </summary>
		public double? distance;
		/// <summary>
		/// The total duration of these directions (including sub-directions if applicable).
		/// </summary>
		public TimeSpan? duration;
		/// <summary>
		/// Text hint for the driver for the action to perform.
		/// </summary>
		public string instructions;
		/// <summary>
		/// A <format id="polyline">route path</format> to display on a map.
		/// </summary>
		public LatLng[] path;
		/// <summary>
		/// For complex routes, the sub-directions provide a breakdown or additional details.
		/// </summary>
		public DispatchDirection[] directions;
		/// <summary>
		/// Unique identifier of the <see cref="DispatchJob"/> or <see cref="DispatchTask"/>.
		/// </summary>
		public ulong? job;
		/// <summary>
		/// The <see cref="DispatchStep.id"/>, if this direction is for <see cref="DispatchJob"/>s.
		/// </summary>
		public ulong? step;
	}
}