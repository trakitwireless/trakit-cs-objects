using System;

namespace trakit.objects {
	/// <summary>
	/// An interface for objects that can be marked as "deleted".
	/// "Deleted" objects can be restored, but are otherwise treated as "not there".
	/// </summary>
	public interface IDeletable {
		/// <summary>
		/// Marked as true for objects that have been deleted.
		/// This value is not present in the JSON scheme when <see cref="deleted"/> is false.
		/// </summary>
		bool? deleted { get; }
		/// <summary>
		/// Timestamp from the action that deleted this object.
		/// This value is not present in the JSON scheme when <see cref="deleted"/> is false.
		/// </summary>
		DateTime? since { get; }
	}
}