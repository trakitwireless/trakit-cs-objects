namespace Trakit.Commands {
	/// <summary>
	/// Gets details of the specified <see cref="SessionDetails"/>.
	/// </summary>
	public class ReqSessionGet : Request {
		/// <summary>
		/// An object to contain the "handle" of the <see cref="SessionDetails"/>.
		/// </summary>
		public ParamHandle session;
	}
}