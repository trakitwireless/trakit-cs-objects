using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="dispatchJob"/> object.
	/// </summary>
	public abstract class ReqDispatchJob : IReqSingle {
		/// <summary>
		/// An object to contain the "id" of the <see cref="DispatchJob"/>.
		/// </summary>
		public ParamId dispatchJob { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.dispatchJob?.id.ToString() ?? "";
	}
}