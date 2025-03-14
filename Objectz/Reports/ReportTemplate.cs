using System;

namespace Trakit.Objects {
	/// <summary>
	/// A partially created report used to quickly build results.
	/// </summary>
	public class ReportTemplate : Component, IIdUlong, INamed, IBelongCompany, IVisual, IDeletable {
		/// <summary>
		/// Unique identifier
		/// </summary>
		public ulong id { get; set; }
		/// <summary>
		/// The company to which this report belongs
		/// </summary>
		/// <seealso cref="Company.id" />
		public ulong company { get; set; }
		/// <summary>
		/// Refers to the type of logic used by this report.
		/// </summary>
		public ReportType kind { get; set; }
		/// <summary>
		/// Name of this report.
		/// </summary>
		/// <override max-length="100" />
		public string name { get; set; }
		/// <summary>
		/// Notes about this report.
		/// </summary>
		public string notes { get; set; }
		/// <summary>
		/// Specified parameters for the report logic, targeted Assets, and filtering Places.
		/// </summary>
		public ReportOptions options;

		/// <summary>
		/// The fill/background colour of the icon.
		/// </summary>
		/// <override max-length="22" format="colour" />
		public string fill { get; set; }
		/// <summary>
		/// Outline and graphic colour.
		/// </summary>
		/// <override max-length="22" format="colour" />
		public string stroke { get; set; }
		/// <summary>
		/// The name of the symbol for this report.
		/// </summary>
		/// <override max-length="22" format="codified" />
		public string graphic { get; set; }

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