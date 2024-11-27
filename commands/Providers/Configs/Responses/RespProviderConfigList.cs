using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="providerConfigs"/>.
	/// </summary>
	public abstract class RespProviderConfigList : Response {
		/// <summary>
		/// The list of requested <see cref="ProviderConfig"/>s.
		/// </summary>
		public ProviderConfig[] providerConfigs;
	}

	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class RespProviderConfigListByCompany : RespProviderConfigList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public RespId company;
	}
}