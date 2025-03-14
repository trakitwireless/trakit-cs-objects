namespace Trakit.Objects {
	/// <summary>
	/// Timezone definition
	/// </summary>
	public class Timezone : IRequestable {
		/// <summary>
		/// Unique timezone code
		/// </summary>
		public string code;
		/// <summary>
		/// Common timezone name
		/// </summary>
		/// <override readonly="true" />
		public string name;
		/// <summary>
		/// Minutes offset from GMT
		/// </summary>
		/// <override readonly="true" />
		public short offset;
		/// <summary>
		/// Indicates whether this timezone abides by daylight savings
		/// </summary>
		/// <override readonly="true" />
		public bool dst;

		/// <summary>
		/// The <see cref="code"/> is the key.
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.code;
	}
}