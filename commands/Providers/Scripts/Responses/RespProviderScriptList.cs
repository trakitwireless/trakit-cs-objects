using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="providerScripts"/>.
	/// </summary>
	public abstract class RespProviderScriptList : Response {
		/// <summary>
		/// The list of requested <see cref="ProviderScript"/>s.
		/// </summary>
		public ProviderScript[] providerScripts;
	}

	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class RespProviderScriptListByCompany : RespProviderScriptList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public RespId company;
	}
}