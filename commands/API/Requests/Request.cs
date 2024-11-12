using System.Linq;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace Trakit.Commands {
	/// <summary>
	/// Base class for all command parameters.
	/// All command parameter classes use this as the base.
	/// </summary>
	/// <remarks>
	/// This class exists solely to create an inheritance chain.
	/// Child classes should contain members required to execute a command.
	/// </remarks>
	public abstract class Request {
		//
		static readonly Regex SPLITTER = new Regex("Req([A-Z][a-z]+)+?((?:Batch)?(?:Get|List|Merge|Delete|Remove|Restore|Suspend|Revive))(By.+)?", RegexOptions.Compiled);
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string[] GetNameParts() => SPLITTER.Match(this.GetType().Name)
											.Groups
											.Cast<Group>()
											.Skip(1)
											.Select(g => g.Value ?? "")
											.ToArray();

		/// <summary>
		/// Identifier used by external system to correlate requests to responses.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public int? reqId { get; set; }
	}
}