namespace Trakit.Commands {
	/// <summary>
	/// An interface that when implemented can be used with validator.byCompany.
	/// </summary>
	/// <category>Companies</category>
	public interface IParameterCompany {
		ParamId company { get; set; }
	}
}