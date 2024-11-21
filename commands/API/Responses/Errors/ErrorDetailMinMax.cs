namespace Trakit.Commands {
	/// <summary>
	/// These are the details of when a value needed to be within a certain range, and was not.
	/// </summary>
	public class ErrorDetailMinMax<T> : ErrorDetail where T : struct {
		/// <summary>
		/// Minimum possible value.
		/// </summary>
		public T? min;
		/// <summary>
		/// Maximum possible value.
		/// </summary>
		public T? max;
	}

	/// <summary>
	/// These are the details of when a value needed to be within a certain range, and was not.
	/// </summary>
	public class ErrorDetailMinMax : ErrorDetailMinMax<double> {
	}
}