namespace Trakit.Objects {
	/// <summary>
	/// An interface for objects that make them more easily visually identifiable.
	/// </summary>
	public interface IVisual {
		/// <summary>
		/// The background colour of the graphic.
		/// </summary>
		string fill { get; }
		/// <summary>
		/// Outline and graphic colour.
		/// </summary>
		string stroke { get; }
		/// <summary>
		/// The name of the symbol for this object.
		/// </summary>
		string graphic { get; }
	}
}