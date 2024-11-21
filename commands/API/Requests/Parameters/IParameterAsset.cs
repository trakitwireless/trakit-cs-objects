namespace Trakit.Commands {
	/// <summary>
	/// An interface that when implemented can be used with validator.byAsset.
	/// </summary>
	/// <category>Assets</category>
	public interface IParameterAsset {
		ParamId asset { get; set; }
	}
}