namespace Trakit.Objects {
	/// <summary>
	/// The type of logged message.
	/// </summary>
	public enum BehaviourLogType : byte {
		/// <summary>
		/// Used for general information messages.
		/// </summary>
		log,
		/// <summary>
		/// Used for more important messages.
		/// </summary>
		info,
		/// <summary>
		/// Used for warnings.
		/// </summary>
		warn,
		/// <summary>
		/// Used for errors.
		/// </summary>
		err,
	}
}