namespace Trakit.Objects {
	/// <summary>
	/// Visual style identification helper.
	/// </summary>
	public class LabelStyle : INamed, IVisual {
		/// <summary>
		/// The name of this visual style.
		/// </summary>
		public string name { get; set; }
		/// <summary>
		/// The codified name of this style
		/// </summary>
		public string code{ get; set; }
		/// <summary>
		/// The background colour given to this style for easy visual identification.
		/// </summary>
		public string fill { get; set; }
		/// <summary>
		/// The text/graphic colour given to this style for easy visual identification.
		/// </summary>
		public string stroke { get; set; }
		/// <summary>
		/// The codified graphic name given to this script for easy visual identification.
		/// </summary>
		public string graphic { get; set; }
		/// <summary>
		/// Notes!
		/// </summary>
		public string notes { get; set; }
	}
}