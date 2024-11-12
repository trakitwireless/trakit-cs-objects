namespace Trakit.Objects {
	/// <summary>
	/// A control to allow the user to attach <see cref="Picture"/>s or <see cref="Document"/>s.
	/// </summary>
	public class FormFieldAttachments : FormFieldBase {
		/// <summary>
		/// These are the attachment types.
		/// </summary>
		protected override FormFieldType[] supported => new[] {
			FormFieldType.pictures,
			FormFieldType.files,
		};

		/// <summary>
		/// Minimum number of <see cref="Document"/>s and/or <see cref="Picture"/>s that must be attached.
		/// </summary>
		public byte? minimum;
		/// <summary>
		/// Maximum number of <see cref="Document"/>s and/or <see cref="Picture"/>s that must be attached.
		/// </summary>
		public byte? maximum;
	}
}