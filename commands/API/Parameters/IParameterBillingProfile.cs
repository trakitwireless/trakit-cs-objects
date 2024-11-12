namespace Trakit.Commands {
	/// <summary>
	/// An interface that when implemented can be used with validator.byBillingProfile.
	/// </summary>
	/// <category>Billing</category>
	public interface IParameterBillingProfile {
		ParamId billingProfile { get; set; }
	}
}