namespace trakit.objects {
	/// <summary>
	/// Any derived class can/should be serialized and given to a user.
	/// </summary>
	public abstract class Component : IRequestable {
		/// <summary>
		/// Object version keys used to validate synchronization for all object properties.
		/// </summary>
		public virtual int[] v { get; set; } = new[] { -1 };

		/// <summary>
		/// Returns a string which can be used as a unique identifier for this object.
		/// Strings are unique for each type of object, but can be identical for different object types.
		/// </summary>
		/// <returns>A string unique for this type of object.</returns>
		public abstract string getKey();
	}
}