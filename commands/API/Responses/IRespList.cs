using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public interface IRespList<TComponent> where TComponent : Component {
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		TComponent[] GetCollection();
	}
}