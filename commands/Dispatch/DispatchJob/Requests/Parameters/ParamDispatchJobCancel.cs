using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Parameters used to cancel a <see cref="DispatchJob"/>, removing it from the dispatcher's and driver's views.
	/// </summary>
	public class ParamDispatchJobCancel : ParamMergeSubscribable {
		/// <summary>
		/// The unique identifier of the <see cref="DispatchJob"/> you want to update.
		/// </summary>
		public ulong id;
		/// <summary>
		/// The reason the <see cref="DispatchJob"/> was cancelled.
		/// The given value is added as a <see cref="DispatchJob.references"/> with the key <c>cancelled</c>.
		/// </summary>
		public string reason;
		/// <summary>
		/// The codified status tag names reflecting the conditions of the <see cref="DispatchJob"/>.
		/// A new tag <c>cancelled</c> is always added.
		/// </summary>
		public List<string> tags;
	}
}