namespace Trakit.Objects {
	/// <summary>
	/// Asset information used in calculating a summary instance.
	/// </summary>
	public class ReportBreakdown {
		/// <summary>
		/// The asset to which this event data belongs.
		/// </summary>
		public ulong asset;
		/// <summary>
		/// Report specific identifier of the event data.
		/// </summary>
		public uint instance;
		/// <summary>
		/// Identifiers of the summary instances that used this event.
		/// </summary>
		public uint[] summaryInstances;
		/// <summary>
		/// General Asset information.
		/// </summary>
		public AssetGeneral general;
		/// <summary>
		/// Advanced/detailed information used.
		/// </summary>
		public AssetAdvanced advanced;
	}
}