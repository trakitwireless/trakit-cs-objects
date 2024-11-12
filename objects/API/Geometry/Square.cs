namespace trakit.objects {
	/// <summary>
	/// A boundary on a flat surface
	/// </summary>
	public class Square {
		/// <summary>
		/// Highest vertical coordinate
		/// </summary>
		public double top;
		/// <summary>
		/// Right-most horizontal coordinate
		/// </summary>
		public double right;
		/// <summary>
		/// Lowest vertical coordinate
		/// </summary>
		public double bottom;
		/// <summary>
		/// Left-most horizontal coordinate
		/// </summary>
		public double left;
		/// <summary>
		/// Width
		/// </summary>
		public double width => this.right - this.left;
		/// <summary>
		/// Height
		/// </summary>
		public double height => this.bottom - this.top;
	}
}