namespace Trakit.Objects {
	/// <summary>
	/// Definition for the name bubble above the icon on a map.
	/// </summary>
	public class IconLabel {
		/// <summary>
		/// The offset from the lat/long in pixels.
		/// </summary>
		public Point anchor;
		/// <summary>
		/// Determines which corner of the label is attached to the anchor.
		/// </summary>
		public string align;
		/// <summary>
		/// Background colour of the label.
		/// </summary>
		public string colour;
	}
}