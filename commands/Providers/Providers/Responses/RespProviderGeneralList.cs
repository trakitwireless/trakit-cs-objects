using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="providerGenerals"/>.
	/// </summary>
	public abstract class RespProviderGeneralList : Response {
		/// <summary>
		/// The list of requested <see cref="ProviderGeneral"/>s.
		/// </summary>
		public ProviderGeneral[] providerGenerals;
	}

	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RespProviderGeneralListByCompany : RespProviderGeneralList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public RespId company;
	}
	/// <summary>
	/// A container owner <see cref="Company"/> of the collection.
	/// </summary>
	public class RespProviderGeneralListByConfig : RespProviderGeneralList {
		/// <summary>
		/// Identifier of the <see cref="ProviderConfig"/> (or <see cref="ProviderConfiguration"/>) to which this collection belongs.
		/// </summary>
		public RespId config;
	}
}