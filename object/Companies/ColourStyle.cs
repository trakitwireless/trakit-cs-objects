namespace Trakit.Objects {
	/// <summary>
	/// Part of the White-labelling profile definitions.
	/// </summary>
	public class ColourStyle {
		/// <summary>
		/// The colour of the background.
		/// </summary>
		/// <override max-length="22" format="colour" />
		public string fill;
		/// <summary>
		/// The colour of the text or outline.
		/// </summary>
		/// <override max-length="22" format="colour" />
		public string stroke;
	}
}