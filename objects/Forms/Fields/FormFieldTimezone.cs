namespace Trakit.Objects {
	/// <summary>
	/// A <see cref="Timezone"/> selection control.
	/// </summary>
	public class FormFieldTimezone : FormFieldBase {
		/// <summary>
		/// Just <see cref="FormFieldType.timezone"/> control type.
		/// </summary>
		protected override FormFieldType[] supported => new[] {
			FormFieldType.timezone,
		};
	}
}