namespace Trakit.Commands {
	/// <summary>
	/// Details for how many and which <see cref="Asset"/>s and <see cref="User"/>s are still using this <see cref="Contact"/>.
	/// </summary>
	public class ErrorDetailContactInUse : ErrorDetailUserGroupInUse {
		public ulong[] assets;
	}
}