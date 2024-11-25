using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Gets the list of <see cref="Session"/> for the specified <see cref="Company"/>.
	/// </summary>
	public class ReqSessionListByCompany : Request, IReqListByCompany {
		/// <summary>
		/// An object to contain the "id" of the <see cref="Company"/>.
		/// </summary>
		public ParamId company { get; set; }
	}
	/// <summary>
	/// Gets the list of <see cref="Session"/>s for the specified <see cref="User"/>.
	/// </summary>
	public class ReqSessionListByUser : Request, IReqListByUser {
		/// <summary>
		/// An object to contain the "login" of the <see cref="User"/>.
		/// </summary>
		public ParamLogin user { get; set; }
	}
}