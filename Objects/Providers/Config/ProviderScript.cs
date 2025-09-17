using System;
using System.Collections.Generic;

namespace Trakit.Objects {
	/// <summary>
	/// This class describes a type of logic applied to a provider.
	/// A script will generate a file which is loaded onto a provider in the field.
	/// </summary>
	public class ProviderScript : Component, IIdUlong, INamed, IBelongCompany, IGlobal, IVisual, IDeletable {
		/// <summary>
		/// Unique identifier of this configuration.
		/// </summary>
		public ulong id { get; set; }
		/// <summary>
		/// The company to which this configuration belongs.
		/// </summary>
		/// <seealso cref="Company.id" />
		public ulong company { get; set; }
		/// <summary>
		/// The nickname given to this configuration
		/// </summary>
		public string name { get; set; }
		/// <summary>
		/// Simple details about how the providers are expected to behave.
		/// </summary>
		public string notes { get; set; }

		/// <summary>
		/// The fill/background colour of the icon.
		/// </summary>
		public string fill { get; set; }
		/// <summary>
		/// Outline and graphic colour.
		/// </summary>
		public string stroke { get; set; }
		/// <summary>
		/// The name of the symbol for this script.
		/// </summary>
		public string graphic { get; set; }

		/// <summary>
		/// Indicates whether this script is available to child companies.
		/// </summary>
		public bool global { get; set; }
		/// <summary>
		/// The type of provider for which this script can be used.
		/// Limiting to a specific model from a manufacturer is accomplished through the block conditions.
		/// </summary>
		public ProviderType kind { get; set; }
		/// <summary>
		/// Blocks of file data which are (optionally) included in the script data file.
		/// </summary>
		public ProviderScriptBlock[] blocks;
		/// <summary>
		/// Parameter definitions for this script, including type-hints and default values.
		/// </summary>
		public Dictionary<string, ProviderScriptParameter> parameters;

		// IRequestable
		/// <summary>
		/// The <see cref="id"/> is the key.
		/// </summary>
		/// <returns></returns>
		public override string GetKey() => this.id.ToString();

		// IDeletable
		/// <summary>
		/// Indicates whether this object was deleted.
		/// </summary>
		public bool? deleted { get; set; }
		/// <summary>
		/// Timestamp from the action that deleted or suspended this object.
		/// </summary>
		public DateTime? since { get; set; }
	}
}