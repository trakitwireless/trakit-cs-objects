namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public interface IReqIDeletable {
		/// <summary>
		/// When true, the command will also return deleted objects.
		/// </summary>
		bool includeDeleted { get; set; }
	}
}