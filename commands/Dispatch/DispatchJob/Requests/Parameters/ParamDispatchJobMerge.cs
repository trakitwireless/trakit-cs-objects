using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Parameters used to create a new, or update an existing <see cref="DispatchJob"/>.
	/// </summary>
	public class ParamDispatchJobMerge : ParamMergeSubscribable {
		/// <summary>
		/// The unique identifier of the <see cref="DispatchJob"/> you want to update.
		/// </summary>
		public ulong? id;
		/// <summary>
		/// The identifier of the <see cref="Company"/> to which the <see cref="DispatchJob"/> belongs.
		/// After creation, this value is read-only.
		/// </summary>
		public ulong? company;
		/// <summary>
		/// The identifier of the <see cref="Asset"/> assigned to the <see cref="DispatchJob"/>.
		/// </summary>
		public ulong? asset;
		/// <summary>
		/// Name for the <see cref="DispatchJob"/>.
		/// </summary>
		public string name;
		/// <summary>
		/// Instructions for the driver to help them complete the <see cref="DispatchJob"/>.
		/// Such as which door to use, a buzz code to enter the facility, etc...
		/// </summary>
		public string instructions;
		/// <summary>
		/// A custom field used to refer the <see cref="DispatchJob"/> to an external system. Examples are a work order, pick-up, waybill, etc...
		/// If value is null, the field is removed from the <see cref="DispatchJob"/>.
		/// If a new value or null is not provided for a current attribute, no change is made.
		/// </summary>
		public Dictionary<string, string> references;
		/// <summary>
		/// A list of <see cref="Document"/> identifiers to attach to the <see cref="DispatchJob"/>.
		/// </summary>
		public List<ulong> attachments;
		/// <summary>
		/// A list of <see cref="FormResult"/> identifiers to attach to the <see cref="DispatchJob"/>.
		/// </summary>
		public List<ulong> forms;
		/// <summary>
		/// The importance of the <see cref="DispatchJob"/> when scheduling for an asset.
		/// </summary>
		public DispatchJobPriority? priority;
		/// <summary>
		/// A list of codified <see cref="CompanyLabels.labels">label</see> names used to relate (unassigned) <see cref="DispatchJob"/>s to <see cref="Asset"/>s.
		/// </summary>
		public List<string> labels;
		/// <summary>
		/// A list of coordinates to visit in order to carry out the work for the <see cref="DispatchJob"/>.
		/// </summary>
		public List<ParamDispatchStepMerge> steps;
	}
}