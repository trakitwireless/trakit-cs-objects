using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Trakit.Commands {
	/// <summary>
	/// Details about why the request failed an authentication process when a <see cref="Machine.secret"/> is used.
	/// </summary>
	/// <remarks>
	/// Only available for <see cref="Machine"/> accounts using the beta services.
	/// </remarks>
	public class ErrorDetailSecret : ErrorDetail {
		/// <summary>
		/// A listing of all the request headres as given.
		/// </summary>
		public Dictionary<string, string[]> headers;
		/// <summary>
		/// The time of the server from when the HTTP request was accepted.
		/// </summary>
		public DateTime accepted;

		/// <summary>
		/// The unique identifier given for the <see cref="Machine"/> to access the system.
		/// </summary>
		public string key;
		/// <summary>
		/// The signature calculated for this request based on all the inputs.
		/// </summary>
		public string signature;
		/// <summary>
		/// The parsed Date header timestamp.
		/// </summary>
		public string date;
		/// <summary>
		/// The parsed <see cref="HttpMethod"/> (should be upper-case).
		/// </summary>
		public string method;
		/// <summary>
		/// Sanitized absolute URL of the request including query-string and fragment, but with any session or api-keys stripped out.
		/// </summary>
		public string uri;
		/// <summary>
		/// The length of the content body (or the Content-Length header value).
		/// </summary>
		public long? length;

		/// <summary>
		/// The input for creating a signature.
		/// </summary>
		public string input;
		/// <summary>
		/// The signature expected.
		/// </summary>
		public string output;
	}
}