using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="asset"/> object.
	/// </summary>
	public abstract class ReqAsset : Request, IReqSingle {
		/// <summary>
		/// An object to contain the "id" of the <see cref="Asset"/>.
		/// </summary>
		public ParamId asset { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string getKey() => this.asset?.id.ToString() ?? "";
	}
}