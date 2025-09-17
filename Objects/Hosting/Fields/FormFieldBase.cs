namespace Trakit.Objects {
	/// <summary>
	/// A base class for the common form field UI members.
	/// </summary>
	public abstract class FormFieldBase : IIdUlong, INamed {
		/// <summary>
		/// A list of supported <see cref="FormFieldType"/>s that this class supports.
		/// </summary>
		protected abstract FormFieldType[] supported { get; }
		/// <summary>
		/// The type of interface control that should be presented to the user.
		/// </summary>
		public FormFieldType kind { get; set; }
		/// <summary>
		/// Identifier for this field.
		/// This value is unique per <see cref="FormTemplate"/>, but is not unique system-wide.
		/// </summary>
		public ulong id { get; set; }
		/// <summary>
		/// Name of the field.
		/// </summary>
		public string name { get; set; }
		/// <summary>
		/// Notes or special instructions for this control.
		/// </summary>
		public string notes { get; set; }
		/// <summary>
		/// When true, a valid value must be given for this field.
		/// </summary>
		public bool required;
		/// <summary>
		/// The default value for the field in the template.
		/// </summary>
		public string value;
		/// <summary>
		/// When false, this field's value is treated as read-only.
		/// </summary>
		public bool editable;
	}
}