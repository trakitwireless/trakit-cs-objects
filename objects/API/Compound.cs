using System.Linq;

namespace trakit.objects {
	/// <summary>
	/// Some objects are made up of the pieces of many objects.
	/// </summary>
	/// <seealso cref="Asset"/>
	/// <seealso cref="Company"/>
	/// <seealso cref="Provider"/>
	/// <seealso cref="User"/>
	public abstract class Compound : Component {
		/// <summary>
		/// A list of individually subscribable objects that make up the compound object.
		/// </summary>
		protected abstract Component[] pieces { get; }

		/// <summary>
		/// Compound objects have multiple <see cref="v"/> values; one for each part of the object.
		/// </summary>
		public override int[] v {
			get => this.pieces.Select(p => p?.v[0] ?? -1).ToArray();
			set {
				for (int i = 0; i < value.Length; i++) {
					this.pieces[i].v = new[] { value[i] };
				}
			}
		}
	}
}