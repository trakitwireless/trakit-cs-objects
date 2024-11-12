namespace Trakit.Objects {
	/// <summary>
	/// A chunk of script and variables used to assemble a working ProviderScript.
	/// </summary>
	public class ProviderScriptBlock {
		/// <summary>
		/// A chunk of the file loaded onto a provider with it's variables replaced with configurable variables.
		/// Trailing or leading whitespace should be included here, so when blocks are merged, so too is the newline characters.
		/// </summary>
		public string content;
		/// <summary>
		/// A regular expression used to match variables in the content.
		/// The regex must contain at least one match-group.
		/// The value fom the last group is what's used as a parameter name.
		/// </summary>
		/// <example>{{([a-z]+)}}</example>
		/// <example>&lt;(var[a-z]+)&gt;</example>
		/// <override max-length="20" />
		public string replace;
		/// <summary>
		/// When defined, this condition matches a <see cref="ProviderScriptParameter"/> defined in the <see cref="ProviderConfig"/> to include or exclude this chunk from the script.
		/// </summary>
		/// <override max-length="50" />
		public string condition;
		/// <summary>
		/// Used in conjunction with condition, this value must match the given ProviderScriptParameter value to have the chunk included.
		/// </summary>
		public string validate;
	}
}