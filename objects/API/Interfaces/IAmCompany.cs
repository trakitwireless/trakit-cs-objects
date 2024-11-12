namespace trakit.objects {
	/// <summary>
	/// An interface for all the Company___ classes.
	/// </summary>
	public interface IAmCompany : IIdUlong {
		/// <summary>
		/// The <see cref="Company"/> to which this <see cref="Company"/> belongs.
		/// </summary>
		ulong parent { get; set; }
	}
}