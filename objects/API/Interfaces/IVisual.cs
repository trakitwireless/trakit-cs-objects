namespace trakit.objects {
	/// <summary>
	/// An interface for objects that make them more easily visually identifiable.
	/// </summary>
	public interface IVisual {
		/// <summary>
		/// The background colour of the graphic.
		/// </summary>
		/// <override max-length="22" format="colour" />
		string fill { get; }
		/// <summary>
		/// Outline and graphic colour.
		/// </summary>
		/// <override max-length="22" format="colour" />
		string stroke { get; }
		/// <summary>
		/// The name of the symbol for this object.
		/// </summary>
		/// <override max-length="22" format="codified" />
		string graphic { get; }
	}
}