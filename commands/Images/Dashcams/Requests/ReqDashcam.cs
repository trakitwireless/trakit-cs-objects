using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the <see cref="dashcam"/> object.
	/// </summary>
	public abstract class ReqDashcam : Request, IReqSingle {
		/// <summary>
		/// An object to contain the "id" of the <see cref="Dashcam"/>.
		/// </summary>
		public ParamId dashcam { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetKey() => this.dashcam?.id.ToString() ?? "";
	}
}