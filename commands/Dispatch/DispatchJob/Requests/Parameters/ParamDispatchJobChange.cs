using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Parameters used to complete, or change the <see cref="DispatchStep"/>s of an existing <see cref="DispatchJob"/>.
	/// </summary>
	public class ParamDispatchJobChange : ParamMergeSubscribable {
		/// <summary>
		/// The unique identifier of the <see cref="DispatchJob"/> you want to update.
		/// </summary>
		public ulong id;
		/// <summary>
		/// Name of the driver who completed the <see cref="DispatchJob"/>.
		/// </summary>
		public string driver;
		/// <summary>
		/// The codified status tag names reflecting the conditions of the <see cref="DispatchJob"/>.
		/// </summary>
		public List<string> tags;
		/// <summary>
		/// A list of notes and signatories from the completion of the <see cref="DispatchJob"/>.
		/// </summary>
		public List<ParamDispatchStepChange> steps;
	}
}