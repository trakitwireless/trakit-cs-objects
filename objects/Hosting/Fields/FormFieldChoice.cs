using System.Collections.Generic;

namespace Trakit.Objects {
	/// <summary>
	/// A single- or multiple-choice input control.
	/// </summary>
	public class FormFieldChoice : FormFieldBase {
		/// <summary>
		/// Just <see cref="FormFieldType.choice"/> control type.
		/// </summary>
		protected override FormFieldType[] supported => new[] {
			FormFieldType.choice,
			FormFieldType.dropdown,
		};
		/// <summary>
		/// The list of choices available and their values.
		/// </summary>
		public Dictionary<string, string> choices;
		/// <summary>
		/// Minimum number of choices that must be selected.
		/// </summary>
		public byte? minimum;
		/// <summary>
		/// Maximum number of choices that must be selected.
		/// </summary>
		public byte? maximum;
	}
}