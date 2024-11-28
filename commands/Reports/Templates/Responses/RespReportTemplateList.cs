using Trakit.Objects;

namespace Trakit.Commands {
	/// <summary>
	/// A container for the requested <see cref="reportTemplates"/>.
	/// </summary>
	public abstract class RespReportTemplateList : Response {
		/// <summary>
		/// The list of requested <see cref="ReportTemplate"/>s.
		/// </summary>
		public ReportTemplate[] reportTemplates;
	}

	/// <summary>
	/// Contains the <see cref="Company.id"/> of the collection.
	/// </summary>
	public class RespReportTemplateListByCompany : RespReportTemplateList {
		/// <summary>
		/// Identifier of the <see cref="Company"/> to which this collection belongs.
		/// </summary>
		public RespId company;
	}
}