namespace Trakit.Commands {
	/// <summary>
	/// 
	/// </summary>
	public class ReqContactBatchMerge : Request {
		/// <summary>
		/// 
		/// </summary>
		public ReqContactMerge.Content[] contacts { get; set; }
	}
}