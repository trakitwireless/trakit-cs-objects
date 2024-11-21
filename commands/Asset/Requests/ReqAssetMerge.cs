using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Container for the command to creates a new, or updates an existing <see cref="Asset"/>.
	/// </summary>
	public class ReqAssetMerge : Request {
		/// <summary>
		/// Parameters given to create or update an <see cref="Asset"/>.
		/// </summary>
		public ParamAssetMerge asset { get; set; }
	}
}