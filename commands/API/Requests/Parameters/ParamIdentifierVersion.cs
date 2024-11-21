namespace Trakit.Commands {
	/// <summary>
	/// A container class used to house the string identifying a <see cref="Provider"/>.
	/// </summary>
	public class ParamIdentifierVersion : ParamIdentifier {
		/// <summary>
		/// Requested version key(s).
		/// </summary>
		public int[] v;
	}
}