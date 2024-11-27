using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="picture"/> object.
	/// </summary>
	public abstract class ReqPicture : Request, IReqSingle {
		/// <summary>
		/// An object to contain the "id" of the <see cref="Picture"/>.
		/// </summary>
		public ParamId picture { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.picture?.id.ToString() ?? "";
	}
}