using System.Collections.Generic;
using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// Parameters used to create or update an <see cref="Company"/>.
	/// </summary>
	public class ParamCompanyMerge : ParamMergeSubscribable {
		/// <summary>
		/// Unique identifier of the Company.
		/// </summary>
		public ulong? id;
		/// <summary>
		/// The unique identifier of this company's parent organization.	
		/// </summary>
		public ulong? parent;
		/// <summary>
		/// The organizational name.
		/// </summary>
		public string name;
		/// <summary>
		/// Notes.
		/// </summary>
		public string notes;
		/// <summary>
		/// Name/value collections of custom fields used to refer to external systems.
		/// If the value is null, the references are removed from the <see cref="Company"/>.
		/// </summary>
		public Dictionary<string, string> references;
		/// <summary>
		/// The list of Contacts from this and other companies broken down by contact role.
		/// </summary>
		public Dictionary<string, List<ulong>> directory;
		/// <summary>
		/// The styles for labels added to Assets, Places, and other things.
		/// </summary>
		public Dictionary<string, LabelStyle> labels;
		/// <summary>
		/// The styles for status tags added to Assets.
		/// </summary>
		public Dictionary<string, LabelStyle> tags;
		/// <summary>
		/// The session lifetime policy.
		/// </summary>
		public ParamSessionPolicy sessionPolicy;
		/// <summary>
		/// The password complexity and expiry policy.
		/// </summary>
		public ParamPasswordPolicy passwordPolicy;
	}
}