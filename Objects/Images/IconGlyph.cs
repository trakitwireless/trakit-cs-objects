namespace Trakit.Objects {
	/// <summary>
	/// The image source and defined status tags which need to be applied to an asset in order to show the image.
	/// </summary>
	public class IconGlyph {
		/// <summary>
		/// A list of codified status tag names.  Any of the tags must be applied to the asset for the image to appear.
		/// </summary>
		public string[] tags;
		/// <summary>
		/// Path to the image.
		/// </summary>
		public string src;
		/// <summary>
		/// Size of the glyph in pixels.
		/// </summary>
		public Size size;
		/// <summary>
		/// The offset from the lat/long in pixels.
		/// </summary>
		public Point anchor;
		/// <summary>
		/// The layer on which this glyph is displayed.
		/// </summary>
		public IconLayer layer;
		/// <summary>
		/// The z-order of this glyph compared to other glyphs on the same layer.
		/// </summary>
		public ushort zIndex;
		/// <summary>
		/// Indicates that this glyph rotate based on GPS bearing.
		/// </summary>
		public bool rotates;
	}
}