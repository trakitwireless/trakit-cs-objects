namespace trakit.objects {
	/// <summary>
	/// An interface for objcts that have an "icon".
	/// </summary>
	public interface IIconic {
		/// <summary>
		/// This thing's <see cref="Icon.id"/>.
		/// </summary>
		ulong icon { get; }
	}
}